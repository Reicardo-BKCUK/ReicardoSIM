using System;

namespace Project1
{
     public class vb6Globals 
      { 
            private static datatp _datatp = null;

            public static datatp datatp
            {
              get {
                if(_datatp == null)
                {
                    _datatp = new datatp();
                }
                return _datatp;
              }
              set {
                if(_datatp != null && !_datatp.IsDisposed)
                {
                }
                else 
                    _datatp = value;
              }
            }

            private static setupplafoniurantunas _setupplafoniurantunas = null;

            public static setupplafoniurantunas setupplafoniurantunas
            {
              get {
                if(_setupplafoniurantunas == null)
                {
                    _setupplafoniurantunas = new setupplafoniurantunas();
                }
                return _setupplafoniurantunas;
              }
              set {
                if(_setupplafoniurantunas != null && !_setupplafoniurantunas.IsDisposed)
                {
                }
                else 
                    _setupplafoniurantunas = value;
              }
            }

            private static setupplafoniuranlintang _setupplafoniuranlintang = null;

            public static setupplafoniuranlintang setupplafoniuranlintang
            {
              get {
                if(_setupplafoniuranlintang == null)
                {
                    _setupplafoniuranlintang = new setupplafoniuranlintang();
                }
                return _setupplafoniuranlintang;
              }
              set {
                if(_setupplafoniuranlintang != null && !_setupplafoniuranlintang.IsDisposed)
                {
                }
                else 
                    _setupplafoniuranlintang = value;
              }
            }

            private static iurantunas _iurantunas = null;

            public static iurantunas iurantunas
            {
              get {
                if(_iurantunas == null)
                {
                    _iurantunas = new iurantunas();
                }
                return _iurantunas;
              }
              set {
                if(_iurantunas != null && !_iurantunas.IsDisposed)
                {
                }
                else 
                    _iurantunas = value;
              }
            }

            private static lihatanggota _lihatanggota = null;

            public static lihatanggota lihatanggota
            {
              get {
                if(_lihatanggota == null)
                {
                    _lihatanggota = new lihatanggota();
                }
                return _lihatanggota;
              }
              set {
                if(_lihatanggota != null && !_lihatanggota.IsDisposed)
                {
                }
                else 
                    _lihatanggota = value;
              }
            }

            private static iuranlintang _iuranlintang = null;

            public static iuranlintang iuranlintang
            {
              get {
                if(_iuranlintang == null)
                {
                    _iuranlintang = new iuranlintang();
                }
                return _iuranlintang;
              }
              set {
                if(_iuranlintang != null && !_iuranlintang.IsDisposed)
                {
                }
                else 
                    _iuranlintang = value;
              }
            }

           public vb6Globals() {  }

      }
} 
