using System;
using Xamarin.Forms;
using SQLite.Net;
using System.Collections.Generic;
using System.Linq;

namespace Bemyguide
{
	public class Database<TTable> where TTable : class, new()
	{

		private SQLiteConnection _connection;

		public Database()
		{

			_connection = DependencyService.Get<ISQLite>().GetConnection();
			_connection.CreateTable<TTable>();

		}

		public IEnumerable<TTable> GetEntries()
		{
			return (from t in _connection.Table<TTable>()
				select t).ToList();
		}
		public IEnumerable<TTable> GetEntries(Func<TTable, bool>param)
		{

			IEnumerable<TTable> 	list = (IEnumerable<TTable>) (from t
				in _connection.Table<TTable> () 
				select t).ToList ();
			return list.Where (param);


		}



		public TTable GetEntry(Func<TTable, bool>param)
		{
			return _connection.Table<TTable>().FirstOrDefault(param);
		}

		public TTable GetEntry()
		{
			return _connection.Table<TTable>().FirstOrDefault();
		}
		public void DeleteEntry(long id)
		{
			_connection.Delete<TTable>(id);
		}

		public void AddEntry(TTable entry)
		{
			try
			{
				AddEntry(entry,false);
			}
			catch (Exception)
			{
				_connection.Update(entry);
			}
		}
		public void AddEntry(TTable entry, bool overwrite)
		{
			if (overwrite) _connection.InsertOrReplace(entry);
			else _connection.Insert(entry);
		}



		// TODO ADD an ADDENtry there update instead of adding if the record allready exist
		//		public void AddEntry2(TTable entry)
		//		{
		//			return _connection.Table<TTable>().FirstOrDefault(param);
		//			if()
		//			{
		//
		//			}
		//			else
		//			{
		//				_connection.Insert(entry);
		//			}
		//
		//		}


	}

}

