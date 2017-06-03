// Decompiled with JetBrains decompiler
// Type: MaBibliotheque.Encodage
// Assembly: MaBibliotheque, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 799CF496-B697-4CAC-87C3-66FFEB4975BB
// Assembly location: C:\Users\a\Dropbox\Perso\1.workspace\4.Microsoft\1.Poo\BibliothequeApplication\BibliothequeApplication\bin\Release\MaBibliotheque.dll

using System;
using System.Text;

namespace MaBibliotheque
{
  internal static class Encodage
  {
    internal static string Crypte(this string chaine)
    {
      return Convert.ToBase64String(Encoding.Default.GetBytes(chaine));
    }

    internal static string Decrypte(this string chaine)
    {
      return Encoding.Default.GetString(Convert.FromBase64String(chaine));
    }
  }
}
