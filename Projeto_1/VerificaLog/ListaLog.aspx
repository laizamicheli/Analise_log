<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaLog.aspx.cs" Inherits="VerificaLog.ListaLog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <meta http-equiv="X-UA-Compatible" content="IE=edge" />
  <meta name="viewport" content="width=device-width, initial-scale=1" />
  <title>Listando Log</title>
 <link href="css/bootstrap.min.css" rel="stylesheet" />
 <link href="css/style.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-inverse navbar-fixed-top">
 <div class="container-fluid">
  <div class="navbar-header">
   <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
    <span class="sr-only">Toggle navigation</span>
    <span class="icon-bar"></span>
    <span class="icon-bar"></span>
    <span class="icon-bar"></span>
   </button>
   <a class="navbar-brand" href="#">Verifica Log</a>
  </div>
  <div id="navbar" class="navbar-collapse collapse">
   <ul class="nav navbar-nav navbar-right">
    
   </ul>
  </div>
 </div>
</nav>
        <hr />
        
     <div id="main" class="container-fluid">
    <div id="top" class="row">
    <div class="col-md-3">
        <h2>Itens</h2>
    </div>
 
    <div class="col-md-6">
        <div class="input-group h2">
            
            <asp:TextBox ID="txtBusca" TextMode="SingleLine" runat="server" CssClass="form-control" placeholder="Pesquisar Itens">


            </asp:TextBox> 

            <%--<input name="data[search]" class="form-control" id="search" type="text" placeholder="Pesquisar Itens" />--%>
            <span class="input-group-btn">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click"/>
                </span>
        </div>
        <br/>
            <span id="lbError" runat="server" Visible="false" class="alert alert-danger"></span>
    </div>
 
    <div class="col-md-3">
       <%-- <a href="add.html" class="btn btn-primary pull-right h2">Novo Item</a>--%>
    </div>
</div> <!-- /#top -->
 
     <hr />
     <div id="list" class="row">
 
    
 
         <div class="table-responsive col-md-12">

        <asp:GridView ID="grdLogs" runat="server" PageSize="50" AllowPaging="true" OnPageIndexChanging="grdLogs_PageIndexChanging" CssClass="table table-striped"></asp:GridView>
        
   



 
     </div>
 </div> <!-- /#list -->

     <div id="bottom" class="row">
     
     </div> <!-- /#bottom -->
 </div>  <!-- /#main -->
    </form>
     <script src="js/jquery.min.js"></script>
 <script src="js/bootstrap.min.js"></script>
</body>
</html>
