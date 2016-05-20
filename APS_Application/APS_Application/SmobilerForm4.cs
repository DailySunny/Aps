using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace APS_Application
{
    partial class NextWeek : Smobiler.Core.MobileForm
    {
        private int LT;//��ȡ����
        private int line_id;//��ȡ�߱��id
        private StringBuilder querystring;
        private StringBuilder title;
        private int week_next;//��ȡ��ѯ������һ��
        private int yearofnextweek;
        
        private void NextWeek_Load(object sender, EventArgs e)
        {
            //Ϊbutton�û�����
            this.next_ver.BackColor = Color.DarkOrange;
            this.history_ver.BackColor = Color.White;
           // NextWeek next = new NextWeek();
            //next.next_week();
            HelpDAO.getYearandWeek();
            this.week_next = HelpDAO.week_next;
            this.yearofnextweek = HelpDAO.yearofnextweek;
            this.title = new StringBuilder();
            this.title.Append("��һ����:");
            this.title.Append(yearofnextweek.ToString());
            this.title.Append("���");
            this.title.Append(week_next.ToString());
            this.title.Append("��");
            this.label3.Text = title.ToString();
            //��ȡ��ǰ�û���line_id�����ж����
            this.line_id = LoginForm.role_id;
            if (10 < line_id && line_id < 40)
            {//��ͨ�೤
                //line_id,week,year,state=1
                this.querystring = new StringBuilder();
                this.querystring.AppendFormat("select [version_no],[comno],[comname],Convert(varchar(12),[create_date],3)as create_date,[line],[amout_01],[amout_02],[amout_03],[amout_04],[amout_05],[amout_06],[amout_07],[amout_total],(case [state] when 1 then '�ѷ���' when 2 then '��ʷ�汾' else 'δ����' end)as [state11] from [vwpt_logistic].[dbo].[prod_plan] where line_id={0} and plan_week={1} and week_year={2} and state=1 order by [version_no]", line_id, week_next, yearofnextweek);
                DataTable table = SqlHelper.getDataShow(querystring.ToString());
                //�Ѳ�ͬ�����ļƻ��ò�ͬ����ɫ���𿪣���Բ鿴���г����ļƻ�
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    NextWeek n = new NextWeek();
                    if (i % 2 == 0)
                    {
                        n.BackColor = Color.Gray;
                        Console.WriteLine("i:"+i);
                    }
                    else
                    {
                        n.BackColor = Color.White;
                        Console.WriteLine("i:" + i);
                    }
                    this.gridView1.DataSource = table;
                    this.gridView1.DataBind();
                }
            }
            else
            {//�ܼ���������˲鿴���м�¼
                if (line_id == 0 || line_id > 40)
                {

                    //sql�����б�
                    //line_id,week,year,state=1
                    this.querystring = new StringBuilder();
                    this.querystring.AppendFormat("select [version_no],[comno],[comname],Convert(varchar(12),[create_date],3)as create_date,[lt],[line],[amout_01],[amout_02],[amout_03],[amout_04],[amout_05],[amout_06],[amout_07],[amout_total],(case [state] when 1 then '�ѷ���' when 2 then '��ʷ�汾' else 'δ����' end)as [state11] from [vwpt_logistic].[dbo].[prod_plan] where state=1 order by lt,line_id, version_no");
                    DataTable table = SqlHelper.getDataShow(querystring.ToString());
                    //�Ѳ�ͬ�����ļƻ��ò�ͬ����ɫ���𿪣���Բ鿴���г����ļƻ�
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        int lt = Convert.ToInt32(table.Rows[i]["lt"]);
                        NextWeek n = new NextWeek();
                        switch (lt)
                        {
                            case 1:
                                n.BackColor = Color.White;
                                break;
                            case 2:
                                n.BackColor = Color.Gray;
                                break;
                            case 3:
                                n.BackColor = Color.Green;
                                break;
                        }
                        this.gridView1.DataSource = table;
                        this.gridView1.DataBind();
                    }
                    this.gridView1.DataSource = table;
                    this.gridView1.DataBind();
                }
                else
                {//��������鿴�Լ�����
                    LT = LoginForm.role_id;
                    this.querystring = new StringBuilder();
                    this.querystring.AppendFormat("select [version_no],[comno],[comname],Convert(varchar(12),[create_date],3)as create_date,[line],[line_id],[amout_01],[amout_02],[amout_03],[amout_04],[amout_05],[amout_06],[amout_07],[amout_total],(case [state] when 1 then '�ѷ���' when 2 then '��ʷ�汾' else 'δ����' end)as [state11] from [vwpt_logistic].[dbo].[prod_plan] where lt='{0}' and state=1", LT);
                    DataTable table = SqlHelper.getDataShow(querystring.ToString());
                    //�����������߱�
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        int lt = Convert.ToInt32(table.Rows[i]["line_id"])%10;
                        NextWeek n = new NextWeek();
                        switch (lt)
                        {
                            case 1:
                                n.BackColor = Color.White;
                                break;
                            case 2:
                                n.BackColor = Color.Gray;
                                break;
                            case 3:
                                n.BackColor = Color.Green;
                                break;
                        }
                        this.gridView1.DataSource = table;
                        this.gridView1.DataBind();
                    }
                    this.gridView1.DataSource = table;
                    this.gridView1.DataBind();
                }
            }
        }

        private void next_ver_Click(object sender, EventArgs e)
        {
            //Ϊbutton�û�����
            this.next_ver.BackColor = Color.DarkOrange;
            this.history_ver.BackColor = Color.White;
            // NextWeek next = new NextWeek();
            //next.next_week();
            HelpDAO.getYearandWeek();
            this.week_next = HelpDAO.week_next;
            this.yearofnextweek = HelpDAO.yearofnextweek;
            this.title = new StringBuilder();
            this.title.Append("��һ����:");
            this.title.Append(yearofnextweek.ToString());
            this.title.Append("���");
            this.title.Append(week_next.ToString());
            this.title.Append("��");
            this.label3.Text = title.ToString();
            //��ȡ��ǰ�û���line_id�����ж����
            this.line_id = LoginForm.role_id;
            if (10 < line_id && line_id < 40)
            {//��ͨ�೤
                //line_id,week,year,state=1
                this.querystring = new StringBuilder();
                this.querystring.AppendFormat("select [version_no],[comno],[comname],Convert(varchar(12),[create_date],3)as create_date,[line],[amout_01],[amout_02],[amout_03],[amout_04],[amout_05],[amout_06],[amout_07],[amout_total],(case [state] when 1 then '�ѷ���' when 2 then '��ʷ�汾' else 'δ����' end)as [state11] from [vwpt_logistic].[dbo].[prod_plan] where line_id={0} and plan_week={1} and week_year={2} and state=1 order by [version_no]", line_id, week_next, yearofnextweek);
                DataTable table = SqlHelper.getDataShow(querystring.ToString());
                this.gridView1.DataSource = table;
                this.gridView1.DataBind();
            }
            else
            {//�ܼ���������˲鿴���м�¼
                if (line_id == 0 || line_id > 40)
                {
                    //sql�����б�
                    //line_id,week,year,state=1
                    this.querystring = new StringBuilder();
                    this.querystring.AppendFormat("select [version_no],[comno],[comname],Convert(varchar(12),[create_date],3)as create_date,[line],[amout_01],[amout_02],[amout_03],[amout_04],[amout_05],[amout_06],[amout_07],[amout_total],(case [state] when 1 then '�ѷ���' when 2 then '��ʷ�汾' else 'δ����' end)as [state11] from [vwpt_logistic].[dbo].[prod_plan] where state=1 order by lt,line_id,version_no");
                    DataTable table = SqlHelper.getDataShow(querystring.ToString());
                    this.gridView1.DataSource = table;
                    this.gridView1.DataBind();
                }
                else
                {//��������鿴�Լ�����
                    LT = LoginForm.role_id;
                    this.querystring = new StringBuilder();
                    this.querystring.AppendFormat("select [version_no],[comno],[comname],Convert(varchar(12),[create_date],3)as create_date,[line],[amout_01],[amout_02],[amout_03],[amout_04],[amout_05],[amout_06],[amout_07],[amout_total],(case [state] when 1 then '�ѷ���' when 2 then '��ʷ�汾' else 'δ����' end)as [state11] from [vwpt_logistic].[dbo].[prod_plan] where lt='{0}' and state=1", LT);
                    DataTable table = SqlHelper.getDataShow(querystring.ToString());
                    this.gridView1.DataSource = table;
                    this.gridView1.DataBind();
                }
            }
        }
        private void history_ver_Click(object sender, EventArgs e)
        {
            //Ϊbutton�û�����
            this.next_ver.BackColor = Color.White;
            this.history_ver.BackColor = Color.DarkOrange;
            //��ȡ��һ�ܵ��������
            HelpDAO.getYearandWeek();
            this.week_next = HelpDAO.week_next;
            this.yearofnextweek = HelpDAO.yearofnextweek;
            this.title = new StringBuilder();
            this.title.Append("��һ����:");
            this.title.Append(yearofnextweek.ToString());
            this.title.Append("���");
            this.title.Append(week_next.ToString());
            this.title.Append("��");
            this.label3.Text = title.ToString();
            //��ȡ��ǰ�û���line_id�����ж����
            this.line_id = LoginForm.role_id;
            if (10 < line_id && line_id < 40)
            {//��ͨ�೤
                //line_id,week,year,state=1
                this.querystring = new StringBuilder();
                this.querystring.AppendFormat("select [version_no],[comno],[comname],Convert(varchar(12),[create_date],3)as create_date,[line],[amout_01],[amout_02],[amout_03],[amout_04],[amout_05],[amout_06],[amout_07],[amout_total],(case [state] when 1 then '�ѷ���' when 2 then '��ʷ�汾' else 'δ����' end)as [state11] from [vwpt_logistic].[dbo].[prod_plan] where line_id={0} and plan_week={1} and week_year={2} and state=2 order by [version_no]", line_id, week_next, yearofnextweek);
                DataTable table = SqlHelper.getDataShow(querystring.ToString());
                this.gridView1.DataSource = table;
                this.gridView1.DataBind();
            }
            else
            {//�ܼ���������˲鿴���м�¼
                if (line_id == 0 || line_id > 40)
                {
                    //sql�����б�
                    //line_id,week,year,state=1
                    this.querystring = new StringBuilder();
                    this.querystring.AppendFormat("select [version_no],[comno],[comname],Convert(varchar(12),[create_date],3)as create_date,[line],[amout_01],[amout_02],[amout_03],[amout_04],[amout_05],[amout_06],[amout_07],[amout_total],(case [state] when 1 then '�ѷ���' when 2 then '��ʷ�汾' else 'δ����' end)as [state11] from [vwpt_logistic].[dbo].[prod_plan] where state=2 order by lt,line_id,version_no");
                    DataTable table = SqlHelper.getDataShow(querystring.ToString());
                    this.gridView1.DataSource = table;
                    this.gridView1.DataBind();
                }
                else
                {//��������鿴�Լ�����
                    LT = LoginForm.role_id;
                    this.querystring = new StringBuilder();
                    this.querystring.AppendFormat("select [version_no],[comno],[comname],Convert(varchar(12),[create_date],3)as create_date,[line],[amout_01],[amout_02],[amout_03],[amout_04],[amout_05],[amout_06],[amout_07],[amout_total],(case [state] when 1 then '�ѷ���' when 2 then '��ʷ�汾' else 'δ����' end)as [state11] from [vwpt_logistic].[dbo].[prod_plan] where lt={0} and state=2", LT);
                    DataTable table = SqlHelper.getDataShow(querystring.ToString());
                    this.gridView1.DataSource = table;
                    this.gridView1.DataBind();
                }
            }
        }

        private void gridView1_ItemClick(object sender, GridViewCellItemEventArgs e)
        {
        }

        private void gridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            //jump l = new jump();
            string q = e.Cell.Items["label4"].Text;
            //Redirect(l);
        }
        //public void next_week()
        //{
            
        //    //��ȡ��һ�ܵ��������
        //    HelpDAO.getYearandWeek();
        //    this.week_next = HelpDAO.week_next; 
        //    this.yearofnextweek = HelpDAO.yearofnextweek;
        //    this.title=new StringBuilder();
        //    this.title.Append("��һ����:");
        //    this.title.Append(yearofnextweek.ToString());
        //    this.title.Append("���");
        //    this.title.Append(week_next.ToString());
        //    this.title.Append("��");
        //    this.label3.Text = title.ToString();
        //    //��ȡ��ǰ�û���line_id�����ж����
        //    this.line_id=LoginForm.role_id;
        //    if(10<line_id&& line_id<40)
        //    {//��ͨ�೤
        //    //line_id,week,year,state=1
        //        this.querystring = new StringBuilder();
        //        this.querystring.AppendFormat("select [version_no],[comno],[comname],Convert(varchar(12),[create_date],3)as create_date,[line],[amout_01],[amout_02],[amout_03],[amout_04],[amout_05],[amout_06],[amout_07],[amout_total],(case [state] when 1 then '�ѷ���' when 2 then '��ʷ�汾' else 'δ����' end)as [state11] from [vwpt_logistic].[dbo].[prod_plan] where line_id={0} and plan_week={1} and week_year={2} and state=1 order by [version_no]", line_id, week_next, yearofnextweek);
        //        DataTable table = SqlHelper.getDataShow(querystring.ToString());
        //        this.gridView1.DataSource = table;
        //        this.gridView1.DataBind();
        //    }else
        //    {//�ܼ���������˲鿴���м�¼
        //        if(line_id==0||line_id>40){
        //            //sql�����б�
        //           //line_id,week,year,state=1
        //            this.querystring = new StringBuilder();
        //            this.querystring.AppendFormat("select [version_no],[comno],[comname],Convert(varchar(12),[create_date],3)as create_date,[amout_01],[amout_02],[amout_03],[amout_04],[amout_05],[amout_06],[amout_07],[amout_total],(case [state] when 1 then '�ѷ���' when 2 then '��ʷ�汾' else 'δ����' end)as [state11] from [vwpt_logistic].[dbo].[prod_plan] where state=1 order by line_id and version_no");
        //            DataTable table = SqlHelper.getDataShow(querystring.ToString());
        //            this.gridView1.DataSource = table;
        //            this.gridView1.DataBind();
        //        }else{//��������鿴�Լ�����
        //            LT=LoginForm.role_id;
        //            this.querystring = new StringBuilder();
        //            this.querystring.AppendFormat("select [version_no],[comno],[comname],Convert(varchar(12),[create_date],3)as create_date,[amout_01],[amout_02],[amout_03],[amout_04],[amout_05],[amout_06],[amout_07],[amout_total],(case [state] when 1 then '�ѷ���' when 2 then '��ʷ�汾' else 'δ����' end)as [state11] from [vwpt_logistic].[dbo].[prod_plan] where lt='{0}' and state=1", LT);
        //            DataTable table = SqlHelper.getDataShow(querystring.ToString());
        //            this.gridView1.DataSource = table;
        //            this.gridView1.DataBind();
        //        }
        //    }
        //}
        //public void history_plan()
        //{
        //    //��ȡ��һ�ܵ��������
        //    HelpDAO.getYearandWeek();
        //    this.week_next = HelpDAO.week_next;
        //    this.yearofnextweek = HelpDAO.yearofnextweek;
        //    this.title = new StringBuilder();
        //    this.title.Append("��һ����:");
        //    this.title.Append(yearofnextweek.ToString());
        //    this.title.Append("���");
        //    this.title.Append(week_next.ToString());
        //    this.title.Append("��");
        //    this.label3.Text = title.ToString();
        //    //��ȡ��ǰ�û���line_id�����ж����
        //    this.line_id = LoginForm.role_id;
        //    if (10 < line_id && line_id < 40)
        //    {//��ͨ�೤
        //        //line_id,week,year,state=1
        //        this.querystring = new StringBuilder();
        //        this.querystring.AppendFormat("select [version_no],[comno],[comname],Convert(varchar(12),[create_date],3)as create_date,[line],[amout_01],[amout_02],[amout_03],[amout_04],[amout_05],[amout_06],[amout_07],[amout_total],(case [state] when 1 then '�ѷ���' when 2 then '��ʷ�汾' else 'δ����' end)as [state11] from [vwpt_logistic].[dbo].[prod_plan] where line_id={0} and plan_week={1} and week_year={2} and state=2 order by [version_no]", line_id, week_next, yearofnextweek);
        //        DataTable table = SqlHelper.getDataShow(querystring.ToString());
        //        this.gridView1.DataSource = table;
        //        this.gridView1.DataBind();
        //    }
        //    else
        //    {//�ܼ���������˲鿴���м�¼
        //        if (line_id == 0 || line_id > 40)
        //        {
        //            //sql�����б�
        //            //line_id,week,year,state=1
        //            this.querystring = new StringBuilder();
        //            this.querystring.AppendFormat("select [version_no],[comno],[comname],Convert(varchar(12),[create_date],3)as create_date,[amout_01],[amout_02],[amout_03],[amout_04],[amout_05],[amout_06],[amout_07],[amout_total],(case [state] when 1 then '�ѷ���' when 2 then '��ʷ�汾' else 'δ����' end)as [state11] from [vwpt_logistic].[dbo].[prod_plan] where state=2 order by line_id and version_no");
        //            DataTable table = SqlHelper.getDataShow(querystring.ToString());
        //            this.gridView1.DataSource = table;
        //            this.gridView1.DataBind();
        //        }
        //        else
        //        {//��������鿴�Լ�����
        //            LT = LoginForm.role_id;
        //            this.querystring = new StringBuilder();
        //            this.querystring.AppendFormat("select [version_no],[comno],[comname],Convert(varchar(12),[create_date],3)as create_date,[amout_01],[amout_02],[amout_03],[amout_04],[amout_05],[amout_06],[amout_07],[amout_total],(case [state] when 1 then '�ѷ���' when 2 then '��ʷ�汾' else 'δ����' end)as [state11] from [vwpt_logistic].[dbo].[prod_plan] where lt={0} and state=2", LT);
        //            DataTable table = SqlHelper.getDataShow(querystring.ToString());
        //            this.gridView1.DataSource = table;
        //            this.gridView1.DataBind();
        //        }
        //    }
        }
    }
