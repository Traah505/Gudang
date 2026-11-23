using System;
using System.Globalization;

namespace GUedang
{
    public static class Fmt
    {
        public static readonly CultureInfo Id = new CultureInfo("id-ID");

        public static string Rupiah(decimal nilai)
        {
            return "Rp " + nilai.ToString("N0", Id);
        }

        public static string Singkat(decimal nilai)
        {
            decimal abs = Math.Abs(nilai);
            string tanda = nilai < 0 ? "-" : "";

            if (abs >= 1_000_000_000m)
                return tanda + (abs / 1_000_000_000m).ToString("0.#", Id) + " M";
            if (abs >= 1_000_000m)
                return tanda + (abs / 1_000_000m).ToString("0.#", Id) + " jt";
            if (abs >= 1_000m)
                return tanda + (abs / 1_000m).ToString("0.#", Id) + " rb";

            return nilai.ToString("0", Id);
        }

        public static string Angka(decimal nilai)
        {
            return nilai.ToString("N0", Id);
        }
    }
}