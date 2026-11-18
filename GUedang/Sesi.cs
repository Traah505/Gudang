using System;
using System.Collections.Generic;
using System.Text;

namespace GUedang
{
    public static class Sesi
    {
        public static string NamaUser { get; set; }
        public static string RoleUser { get; set; }
    
    
        public static void Logout()
        {
            if (!string.IsNullOrEmpty(NamaUser))
                AktivitasStore.Catat(NamaUser, RoleUser, "Logout");

            NamaUser = "";
            RoleUser = "";
            Session.UserAktif = null;
        }
    }
}
