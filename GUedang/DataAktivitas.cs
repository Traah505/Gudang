using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace GUedang
{ 

    public static class DataAktivitas
    {
        public static DataTable Log { get; } = BuatTabel();

        private static DataTable BuatTabel()
        {
            var dt = new DataTable();
            dt.Columns.Add("waktu", typeof(DateTime));
            dt.Columns.Add("aktor", typeof(string));
            dt.Columns.Add("peran", typeof(string));
            dt.Columns.Add("pesan", typeof(string));
            return dt;
        }

        public static void Catat(string pesan)
        {
            Catat("Sistem", "Gudang/Admin", pesan);
        }

        public static void Catat(string aktor, string peran, string pesan)
        {
            Log.Rows.Add(DateTime.Now, aktor ?? "", peran ?? "", pesan ?? "");
        }
    }
}
