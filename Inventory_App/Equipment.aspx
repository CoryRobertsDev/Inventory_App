<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Equipment.aspx.vb" Inherits="Equipment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Equipment Forms</title>
</head>
    <body>
        <main>

                 <form id="Equipment_Form" runat="server">
                    <asp:Panel ID="pnlInsertEquipment" runat="server" BorderStyle="Solid" BorderWidth="1px" Width="349px">
                        <h1 text-align:"center">Equipment</h1>
                        <asp:Label ID="lblEQUIP_TYPE" runat="server" Text="Equipment Type:"></asp:Label>
                        <asp:TextBox ID="txtEQUIP_TYPE" runat="server"></asp:TextBox>
                            <p />
                        <asp:Label ID="lblVENDOR" runat="server" Text="Vendor:"></asp:Label>
                        <asp:TextBox ID="txtVENDOR" runat="server"></asp:TextBox>
                            <p />
                        <asp:Label ID="lblMANUFACTURER" runat="server" Text="Manufacturer:"></asp:Label>
                        <asp:TextBox ID="txtMANUFACTURER" runat="server"></asp:TextBox>
                             <p />
                        <asp:Label ID="lblMODEL" runat="server" Text="Model:"></asp:Label>
                        <asp:TextBox ID="txtMODEL" runat="server"></asp:TextBox>
                             <p />
                        <asp:Label ID="lblSUB_MODEL" runat="server" Text="Sub-Model:"></asp:Label>
                        <asp:TextBox ID="txtSUB_MODEL" runat="server"></asp:TextBox>
                           <p />
                        <asp:Label ID="lblSERIAL_NUM" runat="server" Text="Serial Number:"></asp:Label>
                        <asp:TextBox ID="txtSERIAL_NUM" runat="server"></asp:TextBox>
                             <p />
                        <asp:Label ID="lblUC_SERIAL_NUM" runat="server" Text="UC Serial Number"></asp:Label>
                        <asp:TextBox ID="txtUC_SERIAL_NUM" runat="server"></asp:TextBox>
                             <p />                  
                        <asp:Label ID="lblINVOICE_NUM" runat="server" Text="Invoice Number:"></asp:Label>
                        <asp:TextBox ID="txtINVOICE_NUM" runat="server"></asp:TextBox>
                             <p />                  
                        <asp:Label ID="lblDATE_RECEIVED" runat="server" Text="Date Received:"></asp:Label>
                        <asp:TextBox ID="txtDATE_RECEIVED" runat="server"></asp:TextBox>
                             <p />                        
                        <asp:Label ID="lblREQUESTING_DEPT" runat="server" Text="Requesting Dept.:"></asp:Label>
                        <asp:TextBox ID="txtREQUESTING_DEP" runat="server"></asp:TextBox>
                             <p />                        
                        <asp:Label ID="lblREQUESTED_BY" runat="server" Text="Requested By:"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtREQUESTED_BY" runat="server"></asp:TextBox>
                            <p />                       
                        <asp:Label ID="lblWARRANTY" runat="server" Text="Warranty"></asp:Label>
                        <asp:TextBox ID="txtWARRANTY" runat="server"></asp:TextBox>
                        <hr />
                       <%-- <asp:Label ID="lblSearch" runat="server" Text="Search"></asp:Label>
                        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                        <asp:Button ID="BtnSearch" runat="server" OnClick="BtnSearch_Click" OnClientClick="this.form.reset();return false;" Text="Search" />--%>
                        <hr />                     
                        <asp:Button ID="Submit" runat="server" OnClick="Submit_Click"  Text="Insert Data" />
                        <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update Data" />
    
                    </asp:Panel>
   </form>
                <hr />
               
             

<%--<section class="equpment_ds">
    
                <div class="dynamicString"> <%= dynamicString %></div>
</section>--%>
           

        </main>
</body>
</html>
