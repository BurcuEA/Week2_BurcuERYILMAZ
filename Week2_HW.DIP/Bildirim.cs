﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_HW.DIP
{

    public interface IMesaj : ISend
    {
        string Icerik { get; set; }
    }
    public interface ITelefon : IMesaj
    {
        string TelNo { get; set; }
    }
    public interface IAdres : IMesaj
    {
        string Kime { get; set; }
    }

    public interface ISesliArama : ITelefon
    {
        string SesliAra();
    }

    public interface ISend
    {
        string Send();
    }

    public class Email : IAdres
    {
        public string Kime { get; set; }
        public string Icerik { get; set; }

        public string Send()
        {
            return $"{Icerik},{Kime} adresinize Email gönderildi..";
        }
    }
    public class Sms : ITelefon
    {
        public string TelNo { get; set; }
        public string Icerik { get; set; }

        public string Send()
        {
            return $"{Icerik},{TelNo} numaranıza Sms gönderildi..";
        }
    }
    public class Whatsapp : ISesliArama
    {

        public string TelNo { get; set; }
        public string Icerik { get; set; }

        public string Send()
        {
            return $"{Icerik},{TelNo} numaranıza Whatsapp mesaj gönderildi.. ve " + SesliAra();
        }

        public string SesliAra()
        {
            return "Whatsapp sesli arama yapıldı..";
        }
    }

    //Dependency Inversion Principle
    public class Bildirim
    {
        private IMesaj _mesaj;
        public Bildirim(IMesaj mesaj)
        {
            _mesaj = mesaj;
        }

        public string SendBildirim()
        {
            return _mesaj.Send();
        }
    }
}
