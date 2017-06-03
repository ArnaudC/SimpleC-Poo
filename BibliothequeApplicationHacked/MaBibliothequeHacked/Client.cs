// Decompiled with JetBrains decompiler
// Type: MaBibliotheque.Client
// Assembly: MaBibliotheque, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 799CF496-B697-4CAC-87C3-66FFEB4975BB
// Assembly location: C:\Users\a\Dropbox\Perso\1.workspace\4.Microsoft\1.Poo\BibliothequeApplication\BibliothequeApplication\bin\Release\MaBibliotheque.dll

namespace MaBibliotheque {
    public class Client {
        private string login;
        private string motDePasse;

        public string Login {
            get {
                return this.login;
            }
        }

        public string MotDePasse {
            get {
                return this.motDePasse;
            }
        }

        public Client(string loginClient, string motDePasseClient) {
            this.login = loginClient;
            this.motDePasse = motDePasseClient;
        }

        public override string ToString() {
            return "(" + "hacked " + this.Login + ", " + this.MotDePasse + ")";
        }
    }
}
