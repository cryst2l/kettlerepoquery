using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace kettlerepoquery
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.PerformLayout();
            

    }
        //protected SqlConnection con = new SqlConnection(strCon);
        protected string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["kettlerepoquery.Properties.Settings.ConnectionString"].ToString();

        
        //protected static String strCon = "Data Source=id;Initial Catalog=;Integrated Security=False;User ID=user;Password=pwd";
        //protected static String strCon = "Data Source=;Initial Catalog=;Integrated Security=False;User ID=;Password=";
        

     private void button_query_Click(object sender, EventArgs e)
   {


        
        //    //数据表查询
        //    String sql = "select  '||' + 'FROM' from_table,tb_FROM_step_DATABASE.HOST_NAME,tb_FROM_step_DATABASE.database_name tb_FROM_step_database_name,tb_FROM_step_DATABASE.USERNAME tb_FROM_step_DATABASE_USERNAME,'.' a ,tb_FROM_step_DATABASE.PASSWORD tb_FROM_step_DATABASE_PWD ,tb_TO_step_DATABASE.PASSWORD tb_TO_step_DATABASE_PWD, tb_FROM_TABLE.VALUE_STR tb_FROM_TABLE_VALUE_STR,'-->' + 'TO' to_table ,tb_TO_step_DATABASE.USERNAME tb_TO_step_DATABASE_USERNAME,'.' a, tb_TO_TABLE.VALUE_STR tb_TO_TABLE_VALUE_STR,tb2.ENABLED,tb_dir.ID_DIRECTORY,tb_dir.DIRECTORY_NAME,tb_dir_path.fullpath , tb1.NAME trans_name,tb1.DESCRIPTION,tb1.EXTENDED_DESCRIPTION,tb_FROM_TABLE.CODE tb_FROM_TRAN_CODE,tb_TO_TABLE.CODE tb_TO_TRAN_CODE,tb_dir.*,tb1.*,tb2.*,tb_FROM_TABLE.*,tb_TO_TABLE.*,'||'     ,'||' + 'TO',tb_TO_step_DATABASE.*,'||' + 'FROM',tb_FROM_step_DATABASE.*,'||' + 'FROM',tb_FROM_step_DATABASE.* ,tbjob.ID_JOB R_JOB_ID_JOB,tbjob.ID_DIRECTORY R_JOB_ID_DIRECTORY,tbjob.NAME R_JOB_NAME from R_TRANSFORMATION tb1 left join R_TRANS_HOP tb2 on tb1.ID_TRANSFORMATION = tb2.ID_TRANSFORMATION left join R_STEP_ATTRIBUTE tb_FROM_TABLE on tb_FROM_TABLE.ID_STEP = tb2.id_step_from LEFT join R_STEP_ATTRIBUTE tb_TO_TABLE   on tb_TO_TABLE.ID_STEP = tb2.id_step_to left join dbo.R_DIRECTORY tb_dir on tb_dir.ID_DIRECTORY = tb1.ID_DIRECTORY left join dbo.R_STEP_DATABASE tb_TO_step   on tb_TO_step.ID_STEP = tb_TO_TABLE.ID_STEP left join dbo.R_STEP_DATABASE tb_FROM_step on tb_FROM_step.ID_STEP = tb_FROM_TABLE.ID_STEP left join dbo.R_DATABASE tb_FROM_step_DATABASE on tb_FROM_step.ID_DATABASE = tb_FROM_step_DATABASE.ID_DATABASE left join dbo.R_DATABASE tb_TO_step_DATABASE   on tb_TO_step.ID_DATABASE = tb_TO_step_DATABASE.ID_DATABASE left join(select t1.ID_DIRECTORY, isnull('/' + t6.DIRECTORY_NAME, '') + isnull('/' + t5.DIRECTORY_NAME, '') + isnull('/' + t4.DIRECTORY_NAME, '') + isnull('/' + t3.DIRECTORY_NAME, '') + isnull('/' + t2.DIRECTORY_NAME, '') + isnull('/' + t1.DIRECTORY_NAME, '') + '/' fullpath /*t1.*,t2.*,t3.*,t4.*,t5.*,t6.*, 1.ID_DIRECTORY,isnull(t6.DIRECTORY_NAME,''), isnull(t5.DIRECTORY_NAME,''),isnull(t4.DIRECTORY_NAME,''),isnull(t3.DIRECTORY_NAME,''), isnull(t2.DIRECTORY_NAME,''), isnull(t1.DIRECTORY_NAME,'')  */from(select * from R_DIRECTORY /*where ID_DIRECTORY_PARENT =0*/ ) t1 left join R_DIRECTORY t2 on t1.ID_DIRECTORY_PARENT = t2.ID_DIRECTORY left join R_DIRECTORY t3 on t2.ID_DIRECTORY_PARENT = t3.ID_DIRECTORY left join R_DIRECTORY t4 on t3.ID_DIRECTORY_PARENT = t4.ID_DIRECTORY left join R_DIRECTORY t5 on t4.ID_DIRECTORY_PARENT = t5.ID_DIRECTORY left join R_DIRECTORY t6 on t5.ID_DIRECTORY_PARENT = t6.ID_DIRECTORY) tb_dir_path on tb_dir_path.ID_DIRECTORY = tb_dir.ID_DIRECTORY left join [dbo].[R_JOBENTRY] tbjobe on tbjobe.NAME = tb1.NAME left join[dbo].[R_JOB] tbjob on tbjob.ID_JOB = tbjobe.ID_JOB " +
        //        "where tb_TO_TABLE.code = 'table' " +
                
        //        //"and (tb_FROM_TABLE.code = 'sql') " +
        //        //"and tb2.ENABLED  in  ('Y','1')" +
        //        "  ";


        //   //source part

        //    if(textBox_source_username.Text != "")
        //    {
        //        sql += "and tb_FROM_step_DATABASE.USERNAME like '%" + textBox_source_username.Text + "%'";
        //    }

        //    if (textBox_source_tablename.Text != "")
        //    {
        //        sql += "and tb_FROM_TABLE.VALUE_STR  like '%" + textBox_source_tablename.Text + "%'";
        //    }

        //    if (comboBox_source_step_attribute_code.Text != "")
        //    {
        //        sql += "and tb_FROM_TABLE.code = '" + comboBox_source_step_attribute_code.Text + "'";
        //    }
                       

        //    //job and trans part
        //    if (textBox_tran_name.Text != "")
        //    {
        //        sql += "and  tb1.NAME like '%" + textBox_tran_name.Text + "%'";
        //    }

        //    if (comboBox_enabled.Text != "")
        //    {
        //        sql += "and tb2.ENABLED  in  (" + comboBox_enabled.Text + ")";
        //    }

        //    //target part
        //    if (textBox_target_username.Text != "")
        //    {
        //        sql += "and tb_TO_step_DATABASE.USERNAME like '%" + textBox_target_username.Text + "%'";
        //    }
        //    if (textBox_target_tablename.Text != "")
        //    {
        //        sql += "and tb_TO_TABLE.VALUE_STR like '%" + textBox_target_tablename.Text + "%'";
        //    }

        //    if (textBox_job_name.Text != "")
        //    {
        //        sql += "and tbjob.NAME like '%" + textBox_job_name.Text + "%'";
        //    }
            
        //    sql += "order by tb_TO_step_DATABASE.USERNAME,substring(tb_TO_TABLE.VALUE_STR, 1, 4)";

        //    con.Open();
        //    //创建命令对象，指定要执行sql语句与连接对象conn
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.CommandTimeout = 180;


        //    using (SqlDataAdapter da = new SqlDataAdapter(sql, strCon))
        //    {
        //        DataSet ds = new DataSet();
        //        da.Fill(ds);
        //        this.dataGridView1.DataSource = ds.Tables[0];
        //    }

        //    con.Close();
        //    dataGridView1.PerformLayout();
     }

        
        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_source_username.Text ="";
            textBox_source_tablename.Text = "";
            textBox_tran_name.Text = "";
            textBox_target_username.Text = "";
            textBox_target_tablename.Text = "";
            textBox_job_name.Text = "";

        }

        private void button_job_deployed_Click(object sender, EventArgs e)
        {
            //String strCon = "Data Source=;Initial Catalog=kettle-repos-new;Integrated Security=False;User ID=;Password=";
            SqlConnection con = new SqlConnection(strCon);

        //数据表查询
        String sql = "select  '||' + 'FROM' from_table,tb_FROM_step_DATABASE.name tb_FROM_step_DATABASE_name ,tb_FROM_step_DATABASE.HOST_NAME,tb_FROM_step_DATABASE.database_name tb_FROM_step_database_name,tb_FROM_step_DATABASE.USERNAME tb_FROM_step_DATABASE_USERNAME,'.' a ,tb_FROM_step_DATABASE.PASSWORD tb_FROM_step_DATABASE_PWD ,tb_TO_step_DATABASE.PASSWORD tb_TO_step_DATABASE_PWD, tb_FROM_TABLE.VALUE_STR tb_FROM_TABLE_VALUE_STR,'-->' + " +
                "'TO' to_table ,tb_TO_step_DATABASE.HOST_NAME tb_TO_step_DATABASE_HOST_NAME ,tb_TO_step_DATABASE.database_name  tb_TO_step_DATABASE_database_name  ,tb_TO_step_DATABASE.USERNAME tb_TO_step_DATABASE_USERNAME,'.' a, tb_TO_TABLE.VALUE_STR tb_TO_TABLE_VALUE_STR,tb2.ENABLED,  tb_FROM_TABLE.CODE tb_FROM_TRAN_CODE,tb_TO_TABLE.CODE tb_TO_TRAN_CODE," +
                // "tb_dir.*,tb1.*,tb2.*,tb_FROM_TABLE.*,tb_TO_TABLE.*,'||'     ,'||' + 'TO',tb_TO_step_DATABASE.*,'||' + 'FROM',tb_FROM_step_DATABASE.*,'||' + 'FROM',tb_FROM_step_DATABASE.*, " +
                " tbjob.ID_JOB R_JOB_ID_JOB,tbjob.ID_DIRECTORY R_JOB_ID_DIRECTORY," +
                "( select fullpath from ( 	    select t1.ID_DIRECTORY,                     isnull('/' + t6.DIRECTORY_NAME, '') +                     isnull('/' + t5.DIRECTORY_NAME, '') +                     isnull('/' + t4.DIRECTORY_NAME, '') +                     isnull('/' + t3.DIRECTORY_NAME, '') +                     isnull('/' + t2.DIRECTORY_NAME, '') +                     isnull('/' + t1.DIRECTORY_NAME, '') + '/' fullpath /*t1.*,t2.*,t3.*,t4.*,t5.*,t6.*, 1.ID_DIRECTORY,isnull(t6.DIRECTORY_NAME,''), isnull(t5.DIRECTORY_NAME,''),isnull(t4.DIRECTORY_NAME,''),isnull(t3.DIRECTORY_NAME,''), isnull(t2.DIRECTORY_NAME,''), isnull(t1.DIRECTORY_NAME,'')  */                from (select *                        from R_DIRECTORY /*where ID_DIRECTORY_PARENT =0*/                      ) t1                left join R_DIRECTORY t2                  on t1.ID_DIRECTORY_PARENT = t2.ID_DIRECTORY                left join R_DIRECTORY t3                  on t2.ID_DIRECTORY_PARENT = t3.ID_DIRECTORY                left join R_DIRECTORY t4                  on t3.ID_DIRECTORY_PARENT = t4.ID_DIRECTORY                left join R_DIRECTORY t5                  on t4.ID_DIRECTORY_PARENT = t5.ID_DIRECTORY                left join R_DIRECTORY t6                  on t5.ID_DIRECTORY_PARENT = t6.ID_DIRECTORY ) tt where tt.ID_DIRECTORY =tbjob.ID_DIRECTORY 	   ) R_JOB_ID_DIRECTORY_FULLPATH , tbjob.NAME R_JOB_NAME, tbjob.DESCRIPTION  ,tbjob.JOB_VERSION JOB_VERSION_____________,tbjob.TABLE_NAME_LOG, case when tbjob.JOB_STATUS =2 then '产品' when tbjob.JOB_STATUS = 1 then '草稿'  end as  JOB_STATUS,tbjob.MODIFIED_DATE,tbjob.CREATED_DATE, " +
                " tb_dir.ID_DIRECTORY,tb_dir.DIRECTORY_NAME,tb_dir_path.fullpath TB_DIR_PATH_FULLPATH, tb1.NAME trans_name, tb1.DESCRIPTION,tb1.EXTENDED_DESCRIPTION ,tbjob.EXTENDED_DESCRIPTION" +
                " from R_TRANSFORMATION tb1 left join R_TRANS_HOP tb2 on tb1.ID_TRANSFORMATION = tb2.ID_TRANSFORMATION left join R_STEP_ATTRIBUTE tb_FROM_TABLE on tb_FROM_TABLE.ID_STEP = tb2.id_step_from LEFT join R_STEP_ATTRIBUTE tb_TO_TABLE   on tb_TO_TABLE.ID_STEP = tb2.id_step_to left join dbo.R_DIRECTORY tb_dir on tb_dir.ID_DIRECTORY = tb1.ID_DIRECTORY left join dbo.R_STEP_DATABASE tb_TO_step   on tb_TO_step.ID_STEP = tb_TO_TABLE.ID_STEP left join dbo.R_STEP_DATABASE tb_FROM_step on tb_FROM_step.ID_STEP = tb_FROM_TABLE.ID_STEP left join dbo.R_DATABASE tb_FROM_step_DATABASE on tb_FROM_step.ID_DATABASE = tb_FROM_step_DATABASE.ID_DATABASE left join dbo.R_DATABASE tb_TO_step_DATABASE   on tb_TO_step.ID_DATABASE = tb_TO_step_DATABASE.ID_DATABASE left join(select t1.ID_DIRECTORY, isnull('/' + t6.DIRECTORY_NAME, '') +isnull('/' + t5.DIRECTORY_NAME, '') + isnull('/' + t4.DIRECTORY_NAME, '') + isnull('/' + t3.DIRECTORY_NAME, '') + isnull('/' + t2.DIRECTORY_NAME, '') + isnull('/' + t1.DIRECTORY_NAME, '') + '/' fullpath /*t1.*,t2.*,t3.*,t4.*,t5.*,t6.*, 1.ID_DIRECTORY,isnull(t6.DIRECTORY_NAME,''), isnull(t5.DIRECTORY_NAME,''),isnull(t4.DIRECTORY_NAME,''),isnull(t3.DIRECTORY_NAME,''), isnull(t2.DIRECTORY_NAME,''), isnull(t1.DIRECTORY_NAME,'')  */from(select* from R_DIRECTORY /*where ID_DIRECTORY_PARENT =0*/ ) t1 left join R_DIRECTORY t2 on t1.ID_DIRECTORY_PARENT = t2.ID_DIRECTORY left join R_DIRECTORY t3 on t2.ID_DIRECTORY_PARENT = t3.ID_DIRECTORY left join R_DIRECTORY t4 on t3.ID_DIRECTORY_PARENT = t4.ID_DIRECTORY left join R_DIRECTORY t5 on t4.ID_DIRECTORY_PARENT = t5.ID_DIRECTORY left join R_DIRECTORY t6 on t5.ID_DIRECTORY_PARENT = t6.ID_DIRECTORY) tb_dir_path on tb_dir_path.ID_DIRECTORY = tb_dir.ID_DIRECTORY left join[dbo].[R_JOBENTRY] tbjobe on tbjobe.NAME = tb1.NAME left join[dbo].[R_JOB] tbjob on tbjob.ID_JOB = tbjobe.ID_JOB   " +
                " where tb_TO_TABLE.code = 'table' ";

                //"and (tb_FROM_TABLE.code = 'sql') " +
                //"and tb2.ENABLED  in  ('Y','1')" +
             


            //source part

            if (textBox_source_username.Text != "")
            {
                sql += "and tb_FROM_step_DATABASE.USERNAME like '%" + textBox_source_username.Text + "%'";
            }

            if (textBox_source_tablename.Text != "")
            {
                sql += "and tb_FROM_TABLE.VALUE_STR  like '%" + textBox_source_tablename.Text + "%'";
            }

            if (comboBox_source_step_attribute_code.Text != "")
            {
                sql += "and tb_FROM_TABLE.code = '" + comboBox_source_step_attribute_code.Text + "'";
            }



            //job and trans part
            if (textBox_tran_name.Text != "")
            {
                sql += "and  tb1.NAME like '%" + textBox_tran_name.Text + "%'";
            }

            if (comboBox_enabled.Text != "")
            {
                sql += "and tb2.ENABLED  in  (" + comboBox_enabled.Text + ")";
            }

            if (textBox_job_version.Text != "")
            {
                sql += "and tbjob.JOB_VERSION like '%" + textBox_job_version.Text + "%'";
            }
            

            //target part
            if (textBox_target_username.Text != "")
            {
                sql += "and tb_TO_step_DATABASE.USERNAME like '%" + textBox_target_username.Text + "%' ";
            }
            if (textBox_target_tablename.Text != "")
            {
                sql += "and tb_TO_TABLE.VALUE_STR like '%" + textBox_target_tablename.Text + "%' ";
            }

            if (textBox_job_name.Text != "")
            {
                sql += "and tbjob.NAME like '%" + textBox_job_name.Text + "%' ";
            }

            //if (textBox_hostname.Text != "")
            //{
            //    sql += "and ( "+  tb_FROM_step_DATABASE.database_name  + " like '%" + textBox_hostname "+ %" + textBox_hostname.Text + "%' or " + tb_FROM_step_DATABASE.HOST_NAME + " like  '%" + textBox_hostname.Text + "%'";
            //}

            if (textBox_hostname.Text != "")
            {
                sql += "and ( tb_FROM_step_DATABASE.database_name like '%" + textBox_hostname.Text + "%'  or  tb_FROM_step_DATABASE.HOST_NAME like '%" + textBox_hostname.Text + "%' ) ";
            }
            if (textBox_target_textBox_hostname.Text != "")
            {
                sql += "and ( tb_TO_step_DATABASE.database_name like '%" + textBox_target_textBox_hostname.Text + "%'  or  tb_TO_step_DATABASE.HOST_NAME like '%" + textBox_target_textBox_hostname.Text + "%' ) ";
            }




            //job deployed


            if (comboBox_job_status.Text == "is not null")
            {
                sql += "and tbjob.JOB_STATUS is not null ";
            }


            // sql += "and tbjob.ID_JOB is not null  ";

            sql += "order by tbjob.JOB_STATUS ,tbjob.JOB_VERSION,tb_TO_step_DATABASE.USERNAME,substring(tb_TO_TABLE.VALUE_STR, 1, 4)";

            con.Open();

            //创建命令对象，指定要执行sql语句与连接对象conn
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandTimeout = 180;

            this.dataGridView1.HorizontalScrollingOffset = 0;

            //this.dataGridView1.DataSource = null;

            using (SqlDataAdapter da = new SqlDataAdapter(sql, strCon))
            {
                DataSet ds = new DataSet();
                

                da.Fill(ds);
                

                try
                {
                    //this.dataGridView1.Dispose();
                    this.dataGridView1.DataSource = ds.Tables[0];

                    
                    this.dataGridView1.PerformLayout();


                    //dataGridView1.PerformLayout();
                    // string aaa = this.dataGridView1.ScrollBars.ToString();
                    //this.dataGridView1.SuspendLayout();
                    //int num = int.Parse(sql);
                    //MessageBox.Show("您输入的是：" + sql);

                    // Console.WriteLine("111:"+ aaa);

                }
                catch (Exception)
                //catch (System.ArgumentOutOfRangeException ex)
                {
                    //MessageBox.Show(ex.Message);
                    //MessageBox.Show("1");
                    
                    throw;
                   
                    
                }
                

            }

            //System.Windows.Forms.ScrollBar

            con.Close();
            con.Dispose();
            
        }

        private void btn_find_ktr_job_Click(object sender, EventArgs e)
        {
            //String strCon = "Data Source=;Initial Catalog=;Integrated Security=False;User ID=;Password=";
            SqlConnection con = new SqlConnection(strCon);

            //数据表查询
            String sql = " select t1.ID_JOB	, ID_DIRECTORY	, NAME	, ID_JOBENTRY	, CODE	, VALUE_STR	, DESCRIPTION	, EXTENDED_DESCRIPTION	, JOB_VERSION	" +
                ", JOB_STATUS	, CREATED_USER	, CREATED_DATE	, MODIFIED_USER	, MODIFIED_DATE	" +
                "  from dbo.R_job t1 left join dbo.R_JOBENTRY_ATTRIBUTE t2 on t1.ID_JOB = t2.ID_JOB " +
                " where  code in ('dir_path','name','')  ";

            //"and (tb_FROM_TABLE.code = 'sql') " +
            //"and tb2.ENABLED  in  ('Y','1')" +



            //source part
            if (textBox_job_name.Text != "")
            {
                sql += "and cast(value_str as varchar(max))  like '%" + textBox_job_name.Text + "%' ";
            }


            ////job and trans part
            //if (textBox_tran_name.Text != "")
            //{
            //    sql += "and  tb1.NAME like '%" + textBox_tran_name.Text + "%'";
            //}

            //if (comboBox_enabled.Text != "")
            //{
            //    sql += "and tb2.ENABLED  in  (" + comboBox_enabled.Text + ")";
            //}

            //if (textBox_job_version.Text != "")
            //{
            //    sql += "and tbjob.JOB_VERSION like '%" + textBox_job_version.Text + "%'";
            //}


            ////target part
            //if (textBox_target_username.Text != "")
            //{
            //    sql += "and tb_TO_step_DATABASE.USERNAME like '%" + textBox_target_username.Text + "%' ";
            //}
            //if (textBox_target_tablename.Text != "")
            //{
            //    sql += "and tb_TO_TABLE.VALUE_STR like '%" + textBox_target_tablename.Text + "%' ";
            //}



            ////if (textBox_hostname.Text != "")
            ////{
            ////    sql += "and ( "+  tb_FROM_step_DATABASE.database_name  + " like '%" + textBox_hostname "+ %" + textBox_hostname.Text + "%' or " + tb_FROM_step_DATABASE.HOST_NAME + " like  '%" + textBox_hostname.Text + "%'";
            ////}

            //if (textBox_hostname.Text != "")
            //{
            //    sql += "and ( tb_FROM_step_DATABASE.database_name like '%" + textBox_hostname.Text + "%'  or  tb_FROM_step_DATABASE.HOST_NAME like '%" + textBox_hostname.Text + "%' ) ";
            //}
            //if (textBox_target_textBox_hostname.Text != "")
            //{
            //    sql += "and ( tb_TO_step_DATABASE.database_name like '%" + textBox_target_textBox_hostname.Text + "%'  or  tb_TO_step_DATABASE.HOST_NAME like '%" + textBox_target_textBox_hostname.Text + "%' ) ";
            //}




            ////job deployed


            //if (comboBox_job_status.Text == "is not null")
            //{
            //    sql += "and tbjob.JOB_STATUS is not null ";
            //}


            //// sql += "and tbjob.ID_JOB is not null  ";

            //sql += "order by tbjob.JOB_STATUS ,tbjob.JOB_VERSION,tb_TO_step_DATABASE.USERNAME,substring(tb_TO_TABLE.VALUE_STR, 1, 4)";

            con.Open();

            //创建命令对象，指定要执行sql语句与连接对象conn
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandTimeout = 180;

            this.dataGridView1.HorizontalScrollingOffset = 0;

            //this.dataGridView1.DataSource = null;

            using (SqlDataAdapter da = new SqlDataAdapter(sql, strCon))
            {
                DataSet ds = new DataSet();


                da.Fill(ds);


                try
                {
                    //this.dataGridView1.Dispose();
                    this.dataGridView1.DataSource = ds.Tables[0];


                    this.dataGridView1.PerformLayout();


                    //dataGridView1.PerformLayout();
                    // string aaa = this.dataGridView1.ScrollBars.ToString();
                    //this.dataGridView1.SuspendLayout();
                    //int num = int.Parse(sql);
                    //MessageBox.Show("您输入的是：" + sql);

                    // Console.WriteLine("111:"+ aaa);

                }
                catch (Exception)
                //catch (System.ArgumentOutOfRangeException ex)
                {
                    //MessageBox.Show(ex.Message);
                    //MessageBox.Show("1");

                    throw;


                }


            }

            //System.Windows.Forms.ScrollBar

            con.Close();
            con.Dispose();
        }
        }
    
}
