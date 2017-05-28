using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_FinalC_L.VO
{
    class caVO
    {
            private int    SerialNumber;
            private int    UserID;
            private string Version;
            private string SignatureAlgorithm;
            private string IssuerName;
            private string ValidityPeriod_before;
            private string ValidityPeriod_after;
            private string SubjectName;
            private string PublicKey;
            private string PrivateKey;
            private string Extensions;
            private string ContentSubject;
            private string SignatureCA;
        public caVO(int SerialNumber, int UserID, string Version, string SignatureAlgorithm, string IssuerName, string ValidityPeriod_before, string ValidityPeriod_after, string SubjectName, string PublicKey, string PrivateKey, string Extensions, string ContentSubject, string SignatureCA)
        {
            //
            // TODO: Add constructor logic here
            //
            this.SerialNumber1 = SerialNumber;
            this.UserID1 = UserID;
            this.Version1 = Version;
            this.SignatureAlgorithm1 = SignatureAlgorithm;
            this.IssuerName1 = IssuerName;
            this.ValidityPeriod_before1 = ValidityPeriod_before;
            this.ValidityPeriod_after1 = ValidityPeriod_after;
            this.SubjectName1 = SubjectName;
            this.PublicKey1 = PublicKey;
            this.PrivateKey1 = PrivateKey;
            this.Extensions1 = Extensions;
            this.ContentSubject1 = ContentSubject;
            this.SignatureCA1 = SignatureCA;
    }
        public int SerialNumber1 { get => SerialNumber; set => SerialNumber = value; }
        public int UserID1 { get => UserID; set => UserID = value; }
        public string Version1 { get => Version; set => Version = value; }
        public string SignatureAlgorithm1 { get => SignatureAlgorithm; set => SignatureAlgorithm = value; }
        public string IssuerName1 { get => IssuerName; set => IssuerName = value; }
        public string ValidityPeriod_before1 { get => ValidityPeriod_before; set => ValidityPeriod_before = value; }
        public string ValidityPeriod_after1 { get => ValidityPeriod_after; set => ValidityPeriod_after = value; }
        public string SubjectName1 { get => SubjectName; set => SubjectName = value; }
        public string PublicKey1 { get => PublicKey; set => PublicKey = value; }
        public string PrivateKey1 { get => PrivateKey; set => PrivateKey = value; }
        public string Extensions1 { get => Extensions; set => Extensions = value; }
        public string ContentSubject1 { get => ContentSubject; set => ContentSubject = value; }
        public string SignatureCA1 { get => SignatureCA; set => SignatureCA = value; }
    }
}
