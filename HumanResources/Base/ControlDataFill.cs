using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResources
{
    public static class ControlDataFill
    {
        static RolesOperate ro = new RolesOperate();
        static MingzOperate mo = new MingzOperate();
        static NationalityOperate no = new NationalityOperate();
        static UsersOperate uo = new UsersOperate();
        static TradeOperate to = new TradeOperate();
        static DegreeOperate dgo = new DegreeOperate();
        static ClientPropertyOperate cpo = new BLL.ClientPropertyOperate();
        public static void BindClient_PropertyInCombobox(ComboBox cbo)
        {
            
            cbo.DataSource = cpo.getAllClientProperty();
            cbo.DisplayMember = "ClientProperty_name";
            cbo.ValueMember = "ClientProperty_Id";
        }
        public static void BindRolesInCombobox(ComboBox cbo)
        {
            cbo.DataSource = ro.getAllRoles();      
            cbo.DisplayMember = "Name";
            cbo.ValueMember = "ID";
        }
        public static void FillRolesInCombobox(ComboBox cbo)
        {
            List<Entity.Roles> rl = ro.getAllRoles();
            foreach (Entity.Roles item in rl)
            {
                cbo.Items.Add(item);
            }
            cbo.DisplayMember = "Name";
            cbo.ValueMember = "ID";
        }
        public static void BindRolesInListBox(ListBox lbx)
        {
            List<Entity.Roles> rl = ro.getAllRoles();
            lbx.DataSource = rl;
            lbx.DisplayMember = "Name";
            lbx.ValueMember = "ID";
        }
        public static void BindMingzInComboBox(ComboBox cbo)
        {
            List<Mingz> ml = mo.getAllMingz();
            cbo.DataSource = ml;
            cbo.DisplayMember = "Mingz_name";
            cbo.ValueMember = "Mingz_id";
        }
        public static void BindNationalityInComboBox(ComboBox cbo)
        {
            List<Nationality> ml = no.getAllNationality();
            cbo.DataSource = ml;
            cbo.DisplayMember = "Nationality_name";
            cbo.ValueMember = "Nationality_id";
        }
        public static void BindUsersInComboBox(ComboBox cbo)
        {
            List<Entity.Users> ml = uo.getAllUsers();
            cbo.DataSource = ml;
            cbo.DisplayMember = "User_realName";
            cbo.ValueMember = "User_id";
        }
        
        
        public static void BindTradeInComboBox(ComboBox cbo)
        {
            cbo.DataSource = to.getAllTrade();
            cbo.DisplayMember = "Trade_name";
            cbo.ValueMember = "Trade_id";
        }
        public static void BindDegreeInComboBox(ComboBox cbo)
        {
            cbo.DataSource = dgo.getAllDegree();
            cbo.DisplayMember = "Degree_name";
            cbo.ValueMember = "Degree_id";
        }
        static OwnershipOperate oso = new OwnershipOperate();
        public static void BindOwnershipInComboBox(ComboBox cbo)
        {
            cbo.DataSource = oso.getAllOwnership();
            cbo.DisplayMember = "Ownership_name";
            cbo.ValueMember = "Ownership_Id";
        }
        static ProvinceOperate po = new ProvinceOperate();
        public static void BindProvinceInComboBox(ComboBox cbo)
        {
            cbo.DataSource = po.getAllProvince();
            cbo.DisplayMember = "Province_name";
            cbo.ValueMember = "Province_Id";
        }
        static OperationModelOperate omo = new OperationModelOperate();
        public static void BindOperationModelInComboBox(ComboBox cbo)
        {
            cbo.DataSource = omo.getAllOperationModel();
            cbo.DisplayMember = "OperationModel_name";
            cbo.ValueMember = "OperationModel_Id";
        }
        static BLL.DimensionsOperate dmo = new BLL.DimensionsOperate();
        public static void BindDimensionsInComboBox(ComboBox cbo)
        {
            cbo.DataSource = dmo.getAllDimensions();
            cbo.DisplayMember = "Dimensions_name";
            cbo.ValueMember = "Dimensions_Id";
        }
        static BLL.EmployeesNumberOperate eno = new BLL.EmployeesNumberOperate();
        public static void BindEmployeesNumberInComboBox(ComboBox cbo)
        {
            cbo.DataSource = eno.getAllEmployeesNumber();
            cbo.DisplayMember = "EmployeesNumber_name";
            cbo.ValueMember = "EmployeesNumber_Id";
        }
        static BLL.CityOperate cto = new BLL.CityOperate();
        public static void BindCityInComboBox(ComboBox cbo, int Province_ID)
        {
            cbo.DataSource = cto.getCitysByProvince_ID(Province_ID);
            cbo.DisplayMember = "City_name";
            cbo.ValueMember = "City_Id";
        }
        static CityOperate co = new CityOperate();
        public static void BindCityInComboBox(ComboBox cbo)
        {
            cbo.DataSource = co.getAllCity();
            cbo.DisplayMember = "City_name";
            cbo.ValueMember = "City_id";
        }
        public static void FillCityInComboBox(ComboBox cbo)
        {
            List<Entity.City> c = co.getAllCity();
            foreach (Entity.City item in c)
            {
                cbo.Items.Add(item);
            }
            cbo.DisplayMember = "City_name";
            cbo.ValueMember = "City_id";
        }
    }
}
