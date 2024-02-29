using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class clsPlayer
    {
        #region atributes
        private int id;
        private string name;
        private int result;
        #endregion

        #region contructors
        public clsPlayer()
        {
            id = 0;
            name = string.Empty;
            result = 0;

        }

        public clsPlayer(string name)
        {
            this.id = id+1;
            this.name = name;
            result = 0;
        }
        #endregion

        #region properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Result
        {
            get { return result; }
            set { result = value; }
        }
        #endregion
    }
}
