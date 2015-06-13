<%@ Page Title="Home Page" EnableEventValidation="false" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AndroidToolkit._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<h2 class="demoHeaders">Tabs</h2>
<div id="tabs">
	<ul>
		<li><a href="#tabs-1">XML</a></li>
		<li><a href="#tabs-2">JSON</a></li>
	</ul>
	<div id="tabs-1">
       
        <textarea id="code" name="code"   style="display: none;">qwertyuiiop</textarea>
</br><asp:RadioButton ID="RadioButton1" runat="server" />
          <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

	</div>
	<div id="tabs-2">Phasellus mattis tincidunt nibh. Cras orci urna, blandit id, pretium vel, aliquet ornare, felis. Maecenas scelerisque sem non nisl. Fusce sed lorem in enim dictum bibendum.</div>
</div>

</asp:Content>
