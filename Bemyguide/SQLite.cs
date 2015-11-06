using System;
using SQLite.Net;

namespace Bemyguide
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}
