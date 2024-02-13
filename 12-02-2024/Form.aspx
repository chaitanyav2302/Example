<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="webApplication4.Form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <form>
<div class="form-outline mb-4">
<label class="form-label" for="nameText">StudentName</label>
<asp:TextBox class="form-control" ID="TextBox2" runat="server"></asp:TextBox>
</div>
<div class="form-outline mb-4">
<label class="form-label" for="ageText"> Age</label>
<asp:TextBox class="form-control" ID="TextBox1" runat="server"></asp:TextBox>
</div>
<div class="form-outline mb-4">
<label class="form-label" for="designationText">Course</label>
<asp:TextBox class="form-control" ID="TextBox3" runat="server"></asp:TextBox>
</div>
<div class="text-left pt-1 mb-4 pb-1">

     <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
 </div>
 </form>

    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="StudentId" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting">
        <Columns>
            <asp:BoundField DataField="StudentId" HeaderText="StudentId" ReadOnly="True"></asp:BoundField>
            <asp:BoundField DataField="StudentName" HeaderText="StudentName"></asp:BoundField>
            <asp:BoundField DataField="Age" HeaderText="Age"></asp:BoundField>
            <asp:BoundField DataField="Course" HeaderText="Course"></asp:BoundField>
            <asp:CommandField ShowEditButton="True" ButtonType="Button"></asp:CommandField>
            <asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
        </Columns>
    </asp:GridView>
</asp:Content>

