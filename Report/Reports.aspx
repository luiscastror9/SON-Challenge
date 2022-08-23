<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="Report.Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row">
          <div class="jumbotron">
       
    </div>
        <div class="col-md-4">
             <h2>Number of Orders in Week</h2>
             <asp:GridView ID="GridView1" CssClass="table table-bordered table-striped" runat="server"
            CellPadding="5" CellSpacing="2" AutoGenerateColumns="false">
            <Columns>
               
                <asp:BoundField DataField="OrderNumber" HeaderText="Number of Orders in Week" />
            </Columns>
        </asp:GridView>
        </div>
        <div class="col-md-4">
            <h2> most popular hours of the week</h2>
           <asp:GridView ID="GridView2" CssClass="table table-bordered table-striped" runat="server"
            CellPadding="5" CellSpacing="2" AutoGenerateColumns="False" ClientIDMode = "Static" ShowHeaderWhenEmpty="true" ShowHeader="True">
            <Columns>
                
                <asp:TemplateField HeaderText="Rank">
                    <ItemTemplate>
                        <%#Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Hour" HeaderText="Hour" />
            </Columns>
        </asp:GridView>
        </div>
        <div class="col-md-4">
             <h2> most popular mix–ins</h2>
           <asp:GridView ID="GridView3" CssClass="table table-bordered table-striped" runat="server"
            CellPadding="5" CellSpacing="2" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText="Rank">
                    <ItemTemplate>
                        <%#Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Name" HeaderText="Name" />
            </Columns>
        </asp:GridView>
        </div>
    </div>
        <link type="text/css" rel="stylesheet" href="https://cdn.datatables.net/1.10.9/css/dataTables.bootstrap.min.css" />
    <link type="text/css" rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
    <link type="text/css" rel="stylesheet" href="https://cdn.datatables.net/responsive/1.0.7/css/responsive.bootstrap.min.css" />
    <script type="text/javascript" src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.9/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/responsive/1.0.7/js/dataTables.responsive.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.9/js/dataTables.bootstrap.min.js"></script>
    <script type="text/javascript" src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
    <script type="text/javascript">
        //$(function () {
        //    $("[id*=GridView1]").prepend($("<thead></thead>").append($(this).find("tr:first"))).DataTable({
        //        "paging": true,
        //        "lengthChange": false,
        //        "searching": false,
        //        "ordering": true,
        //        "info": true,
        //        "autoWidth": true
        //    });
        //})
        //$(function () {
        //    $("[id*=GridView2]").prepend($("<thead></thead>").append($(this).find("tr:first"))).DataTable({
        //        "paging": true,
        //        "lengthChange": false,
        //        "searching": false,
        //        "ordering": true,
        //        "info": true,
        //        "autoWidth": true
        //    });
        //})
        //$(function () {
        //    $("[id*=GridView3]").prepend($("<thead></thead>").append($(this).find("tr:first"))).DataTable({
        //        "paging": true,
        //        "lengthChange": false,
        //        "searching": false,
        //        "ordering": true,
        //        "info": true,
        //        "autoWidth": true
        //    });
        //})
    </script>
</asp:Content>
