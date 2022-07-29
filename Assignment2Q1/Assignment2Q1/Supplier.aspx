<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Supplier.aspx.cs" ClientTarget="uplevel" Inherits="Assignment2Q1.Supplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
            <br/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Product Registration<br />
            <br />
            <br />
            Supplier ID:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Supplier_ID" runat="server" TextMode="Number"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Supplier_ID" 
                Display="Dynamic" ErrorMessage="*required(Must be a Number)" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
            Supplier Name:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Supplier_name" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Supplier_name"
                Display="Dynamic" ErrorMessage="*Name is required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
            Product Name:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="Product_name" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic"
               ControlToValidate="Product_name"  ErrorMessage="This Field Can't be Empty" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
            Product Quantity:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="Product_quantity" runat="server" TextMode="Number">
             </asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
             ControlToValidate="Product_quantity" Display="Dynamic" ErrorMessage="*Required" ForeColor="#CC0000">
             </asp:RequiredFieldValidator>&nbsp;
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Product_quantity" Display="Dynamic"
                ErrorMessage="(Range Must Lie between 100 to 400)" ForeColor="#CC0000"
                MaximumValue="400" MinimumValue="100"></asp:RangeValidator>
            <br />
            <br />
            Supply Date:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="Supply_date" runat="server" TextMode="Date"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Display="Dynamic"
                ErrorMessage="*Required" ForeColor="#CC0000" ControlToValidate="Supply_date"></asp:RequiredFieldValidator>
            &nbsp;
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                 ControlToValidate="Supply_date" Display="Dynamic" 
                ErrorMessage="Date can't be Future or Past Date" ForeColor="#CC0000"></asp:CompareValidator>
            <br />
            <br /> 
            Received By:&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="Received_By" runat="server">
                <asp:ListItem>parrekevin@gmail.com</asp:ListItem>
                <asp:ListItem>asp@gmail.com</asp:ListItem>
                <asp:ListItem>kevin@fis.com</asp:ListItem>
                <asp:ListItem>dotnet@rps.com</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                ErrorMessage="Email ID is Required " ControlToValidate="Received_By" Display="Dynamic" 
                ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
            Receiver Phone:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Receiver_phone" runat="server" TextMode="Phone"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                ErrorMessage="Phone Number can't be Empty" ControlToValidate="Receiver_phone" 
                Display="Dynamic" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
            Is Invoiced:&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server"
                ErrorMessage="Selection is Must!" ControlToValidate="IsInvoiced" Display="Dynamic" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                &nbsp;<asp:RadioButtonList ID="IsInvoiced" runat="server">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:RadioButtonList>
            <br />
           
            <asp:Button ID="BtnSave" runat="server" Text="Save Record" Width="119px" OnClick="BtnSave_Click" />
            <br />
            <br />
            

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
