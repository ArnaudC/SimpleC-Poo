// Decompiled with JetBrains decompiler
// Type: MaBibliotheque.Generateur
// Assembly: MaBibliotheque, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 799CF496-B697-4CAC-87C3-66FFEB4975BB
// Assembly location: C:\Users\a\Dropbox\Perso\1.workspace\4.Microsoft\1.Poo\BibliothequeApplication\BibliothequeApplication\bin\Release\MaBibliotheque.dll

using System;

namespace MaBibliotheque {
    public static class Generateur {
        private static Random r = new Random();

        public static string ObtenirIdentifiantUnique() {
            string empty = string.Empty;
            for (int index = 0; index < 10; ++index)
                empty += r.Next(0, 100);
            return empty.Crypte();
        }
    }
}
