using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle_investigation_system
{
    class OracleCommand
    {
        private string p;
        private System.Data.OleDb.OleDbConnection con;

        public OracleCommand(string p, System.Data.OleDb.OleDbConnection con)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.con = con;
        }

        internal void ExecuteScalar()
        {
            throw new NotImplementedException();
        }

        internal void ExecuteOracleScalar()
        {
            throw new NotImplementedException();
        }
    }
}
