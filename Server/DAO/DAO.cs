using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ThreeLayerDemo.Core
{
    public class DAO
    {
        private dbConnection conn;

        /// <constructor>
        /// Constructor UserDAO
        /// </constructor>
        public DAO()
        {
            conn = new dbConnection();
        }

        /// <method>
        /// Get User Email By Firstname or Lastname and return DalaTable
        /// </method>
        public DataTable searchUserId(string username, string pass)
        {
            string query = string.Format("SELECT UserId FROM TAIKHOAN WHERE UserName=@UserName and PassWord=@PassWord");
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(username);
            sqlParameters[1] = new SqlParameter("@PassWord", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(pass);
            return conn.executeSelectQuery(query, sqlParameters);
        }

        /// <method>
        /// Get CA By UserId and return DalaTable
        /// </method>
        public DataTable searchCAByUserId(string userid)
        {
            string query = @"SELECT [SerialNumber],[Version],[SignatureAlgorithm],[IssuerName],[ValidityPeriod_before],[ValidityPeriod_after],[SubjectName],[PublicKey],[Extensions],[ContentSubject],[SignatureCA] FROM [CHUNGCHI] WHERE UserId = @UserId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@UserId", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(userid);
            return conn.executeSelectQuery(query, sqlParameters);
        }
        public bool themTaiKhoan(string UserName, string PassWord, string CompanyName, string Email, string Phone)
        {
            string query = string.Format("INSERT INTO TAIKHOAN(UserName, PassWord, CompanyName, Email, Phone) VALUES (@UserName, @PassWord, @CompanyName, @Email, @Phone)");
            SqlParameter[] sqlParameters = new SqlParameter[5];
			sqlParameters[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(UserName);
            sqlParameters[1] = new SqlParameter("@PassWord", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(PassWord);
            sqlParameters[2] = new SqlParameter("@CompanyName", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(CompanyName);
            sqlParameters[3] = new SqlParameter("@Email", SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(Email);
            sqlParameters[4] = new SqlParameter("@Phone", SqlDbType.Int);
			sqlParameters[4].Value = Convert.ToInt32(Phone);
            return conn.executeInsertQuery(query, sqlParameters);
        }
        public bool themCA(int SerialNumber, int UserID, string Version, string SignatureAlgorithm, string IssuerName, string ValidityPeriod_before, string ValidityPeriod_after, string SubjectName, string PublicKey, string PrivateKey, string Extensions, string ContentSubject, string SignatureCA)
        {
            string query = string.Format(@"INSERT INTO [CHUNGCHI]
                                                       ([SerialNumber]
                                                       ,[UserID]
                                                       ,[Version]
                                                       ,[SignatureAlgorithm]
                                                       ,[IssuerName]
                                                       ,[ValidityPeriod_before]
                                                       ,[ValidityPeriod_after]
                                                       ,[SubjectName]
                                                       ,[PublicKey]
                                                       ,[PrivateKey]
                                                       ,[Extensions]
                                                       ,[ContentSubject]
                                                       ,[SignatureCA])
                                                 VALUES
                                                       (@SerialNumber
                                                       ,@UserID
                                                       ,@Version
                                                       ,@SignatureAlgorithm
                                                       ,@IssuerName
                                                       ,@ValidityPeriod_before
                                                       ,@ValidityPeriod_after
                                                       ,@SubjectName
                                                       ,@PublicKey
                                                       ,@PrivateKey
                                                       ,@Extensions
                                                       ,@ContentSubject
                                                       ,@SignatureCA)");
            SqlParameter[] sqlParameters = new SqlParameter[13];
            sqlParameters[0] = new SqlParameter("@SerialNumber", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(SerialNumber);
            sqlParameters[1] = new SqlParameter("@UserID", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToInt32(UserID);
            sqlParameters[2] = new SqlParameter("@Version", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(Version);
            sqlParameters[3] = new SqlParameter("@SignatureAlgorithm", SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(SignatureAlgorithm);
            sqlParameters[4] = new SqlParameter("@IssuerName", SqlDbType.VarChar);
            sqlParameters[4].Value = Convert.ToString(IssuerName);
            sqlParameters[5] = new SqlParameter("@ValidityPeriod_before", SqlDbType.Date);
            sqlParameters[5].Value = Convert.ToDateTime(ValidityPeriod_before);
            sqlParameters[6] = new SqlParameter("@ValidityPeriod_after", SqlDbType.Date);
            sqlParameters[6].Value = Convert.ToDateTime(ValidityPeriod_after);
            sqlParameters[7] = new SqlParameter("@SubjectName", SqlDbType.VarChar);
            sqlParameters[7].Value = Convert.ToString(SubjectName);
            sqlParameters[8] = new SqlParameter("@PublicKey", SqlDbType.VarChar);
            sqlParameters[8].Value = Convert.ToString(PublicKey);
            sqlParameters[9] = new SqlParameter("@PrivateKey", SqlDbType.VarChar);
            sqlParameters[9].Value = Convert.ToString(PrivateKey);
            sqlParameters[10] = new SqlParameter("@Extensions", SqlDbType.VarChar);
            sqlParameters[10].Value = Convert.ToString(Extensions);
            sqlParameters[11] = new SqlParameter("@ContentSubject", SqlDbType.VarChar);
            sqlParameters[11].Value = Convert.ToString(ContentSubject);
            sqlParameters[12] = new SqlParameter("@SignatureCA", SqlDbType.Int);
            sqlParameters[12].Value = Convert.ToInt32(SignatureCA);
            return conn.executeInsertQuery(query, sqlParameters);
        }
    }
}
