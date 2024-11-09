<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationHTTP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div class="row">
            <!-- Input fields for parameters -->
            <div style="margin-bottom: 20px">
                <asp:Label runat="server" Text="Value 1 for Add:"></asp:Label>
                <asp:TextBox runat="server" ID="inputAdd1"></asp:TextBox>
                <br />
                <asp:Label runat="server" Text="Value 2 for Add:"></asp:Label>
                <asp:TextBox runat="server" ID="inputAdd2"></asp:TextBox>
            </div>
            <div style="margin-bottom: 20px">
                <asp:Label runat="server" Text="Value 1 for Concat:"></asp:Label>
                <asp:TextBox runat="server" ID="inputConcat1"></asp:TextBox>
                <br />
                <asp:Label runat="server" Text="Value 2 for Concat:"></asp:Label>
                <asp:TextBox runat="server" ID="inputConcat2"></asp:TextBox>
            </div>
            <div style="margin-bottom: 20px">
                <asp:Label runat="server" Text="Object A (f, k, s):"></asp:Label>
                <asp:TextBox runat="server" ID="inputA_f" Placeholder="f"></asp:TextBox>
                <asp:TextBox runat="server" ID="inputA_k" Placeholder="k"></asp:TextBox>
                <asp:TextBox runat="server" ID="inputA_s" Placeholder="s"></asp:TextBox>
            </div>
            <div style="margin-bottom: 20px">
                <asp:Label runat="server" Text="Object B (f, k, s):"></asp:Label>
                <asp:TextBox runat="server" ID="inputB_f" Placeholder="f"></asp:TextBox>
                <asp:TextBox runat="server" ID="inputB_k" Placeholder="k"></asp:TextBox>
                <asp:TextBox runat="server" ID="inputB_s" Placeholder="s"></asp:TextBox>
            </div>
            <div style="margin-bottom: 20px">
                <!-- Submit button -->
                <asp:Button runat="server" ID="btnCalculate" Text="Calculate" OnClick="btnCalculate_Click" />
            </div>
            <div>
                <!-- Result display -->
                <asp:Label runat="server" Text="Add Result:"></asp:Label>
                <asp:TextBox runat="server" ID="addResult" ReadOnly="True" Width="300px"></asp:TextBox>
                <br />
                <asp:Label runat="server" Text="Concat Result:"></asp:Label>
                <asp:TextBox runat="server" ID="concatResult" ReadOnly="True" Width="300px"></asp:TextBox>
                <br />
                <asp:Label runat="server" Text="Sum Result (f, k, s):"></asp:Label>
                <asp:TextBox runat="server" ID="sumResultF" ReadOnly="True" Width="100px" Placeholder="f"></asp:TextBox>
                <asp:TextBox runat="server" ID="sumResultK" ReadOnly="True" Width="100px" Placeholder="k"></asp:TextBox>
                <asp:TextBox runat="server" ID="sumResultS" ReadOnly="True" Width="100px" Placeholder="s"></asp:TextBox>
            </div>
        </div>
    </main>
</asp:Content>
