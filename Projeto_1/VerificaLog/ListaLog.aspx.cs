using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dao;

namespace VerificaLog
{
    public partial class ListaLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(!IsPostBack)
                {
                    
                grdbind();
                
                }
            }
            catch(Exception ex)
            {
                lbError.InnerHtml = ex.Message;
                lbError.Visible = true;

            }

        }
        private void grdbind()
        {
            try
            {
                baseDao objbase = new baseDao();
                grdLogs.DataSource = objbase.Listar();
                grdLogs.DataBind();
            }
            catch (Exception ex)
            {
                lbError.InnerHtml = ex.Message;
                lbError.Visible = true;
            }
        }
        private void grdbind(string strbusca)
        {
            try
            {
                baseDao objbase = new baseDao();
                grdLogs.DataSource = objbase.Iquery().Where(qr=>
                qr.DiaMes.Contains(strbusca) || 
                qr.Hora.Contains(strbusca)||
                qr.Ocorrencia.Contains(strbusca)||
                qr.Descrição.Contains(strbusca)
                ).ToList() ;
                grdLogs.DataBind();
            }
            catch (Exception ex)
            {
                lbError.InnerHtml = ex.Message;
                lbError.Visible = true;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    grdbind(txtBusca.Text);   
                }
                catch (Exception ex)
                {
                    lbError.InnerHtml = ex.Message;
                    lbError.Visible = true;
                }
            }
        }

        protected void grdLogs_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                grdLogs.PageIndex = e.NewPageIndex;
                if(string.IsNullOrEmpty(txtBusca.Text))
                {
                    grdbind();
                }
                else
                {
                    grdbind(txtBusca.Text);
                }
            }
            catch (Exception ex)
            {
                lbError.InnerHtml = ex.Message;
                lbError.Visible = true;
            }

        }
    }
}