﻿using System;
using EF_Context;
using EF_Context.Repositories;
using DAL_Repository.Repositories;
using System.Linq;
using System.Data.Entity;
using System.Diagnostics;

namespace DAL_Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private IsisContext _context;

        public UnitOfWork(IsisContext context)
        {
            _context = context;
            Datums = new DatumRepository(context);
            Klanten = new KlantRepository(context);
            KlantTypes = new KlantTypeRepository(context);
            Strijkers = new StrijkerRepository(context);
            Prestaties = new PrestatieRepository(context);
            StukPrestaties = new StukPrestatieRepository(context);
            TijdPrestaties = new TijdPrestatieRepository(context);
        }

        public IDatumRepository Datums { get; private set; }
        public IKlantRepository Klanten { get; private set; }
        public IKlantTypeRepository KlantTypes { get; private set; }
        public IStrijkerRepository Strijkers { get; private set; }
        public IPrestatieRepository Prestaties { get; private set; }
        public IStukPrestatieRepository StukPrestaties { get; private set; }
        public ITijdPrestatieRepository TijdPrestaties { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public bool HasChanges()
        {
            //return _context.ChangeTracker.HasChanges();

            var changedEntries = _context.ChangeTracker.Entries();
            return changedEntries.Any(x => x.State == EntityState.Modified || x.State == EntityState.Added || x.State == EntityState.Deleted);
        }

        public void DiscardChanges()
        {
            try
            {
                //Reset changes made to those entries
                foreach (var entry in _context.ChangeTracker.Entries().Where(x => x.State == EntityState.Modified))
                {
                    //entry.CurrentValues.SetValues(entry.OriginalValues);
                    entry.State = EntityState.Unchanged;
                }

                foreach (var entry in _context.ChangeTracker.Entries().Where(x => x.State == EntityState.Added))
                {
                    entry.State = EntityState.Detached;
                }

                foreach (var entry in _context.ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted))
                {
                    entry.State = EntityState.Unchanged;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void BackupDatabase(string path)
        {
            var dbname = _context.Database.Connection.Database;
            _context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, $@"
                BACKUP DATABASE {dbname}
                    TO DISK = '{path}\Backup ISIS Databank {DateTime.Now.ToString("dd_MM_yyyy HH-mm-ss")}.bak'
                        WITH FORMAT,
                        MEDIANAME = 'Z_SQLServerBackups',
                        NAME = 'Full Backup of ISIS';");
        }

        public void RestoreDatabase(string path)
        {
            var dbname = _context.Database.Connection.Database;
            _context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, $@"
                USE master;
                ALTER DATABASE {dbname} SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                RESTORE DATABASE {dbname}
                    FROM DISK = '{path}';
                ALTER DATABASE {dbname} SET Multi_User
                ");
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
