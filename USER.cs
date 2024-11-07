using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    internal class USER : IUser
    {
        string _kadi, _sifre, _rol;
        public int Id { get; set; }
        public string Kadi { get => _kadi; set => _kadi = value.ToLower(); }
        public string Sifre { get => _sifre; set => _sifre = value; }
        public string Rol { get => _rol; set => _rol = value; }
        public virtual string GetInfo();
    }
    internal sealed class Admin : USER
    {
        public int Fiyat { get; set; }
        public int Kdv { get; set; }
        public string Sonuc { get { return GetInfo(); } }
        public override string GetInfo()
        {
            return $", Fiyat: {Fiyat}, KDV: {Kdv}, Sonuç: {Fiyat + Fiyat * Kdv /100}";
        }
    }
}
