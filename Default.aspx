<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AndroidTookit.Default" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSplitter" tagprefix="dx" %>

<!DOCTYPE html>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Android Toolkit</title>
    <style type="text/css">
        .auto-style1 {
            font-weight: normal;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" Theme="Aqua" Width="100%" EnableCallbackCompression="False" EnableViewState="False" EncodeHtml="False" TabPosition="Left">
                <TabPages>
                    <dx:TabPage Text="XML TO VIEW">
                        <ActiveTabImage IconID="content_barcode_32x32">
                        </ActiveTabImage>
                        <TabImage IconID="content_barcode_32x32">
                        </TabImage>
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl1" runat="server">
                                <dx:ASPxSplitter ID="ASPxSplitter1" runat="server" Height="600px" Theme="Metropolis" Width="100%">
                                    <Panes>
                                        <dx:SplitterPane>
                                            <ContentCollection>
                                                <dx:SplitterContentControl ID="SplitterContentControl1" runat="server">
                                                    <dx:ASPxMemo ID="txtXML" runat="server" Height="500px" Theme="Aqua" Width="100%" ToolTip="XML Code">
                                                    </dx:ASPxMemo>
                                                    <dx:ASPxButton ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click"
                                                        Theme="Aqua" Width="100px">
                                                    </dx:ASPxButton>
                                                </dx:SplitterContentControl>
                                            </ContentCollection>
                                        </dx:SplitterPane>
                                        <dx:SplitterPane>
                                            <ContentCollection>
                                                <dx:SplitterContentControl ID="SplitterContentControl2" runat="server">
                                                    <dx:ASPxMemo ID="txtView" runat="server" Height="500px" Theme="Aqua" Width="100%" ToolTip="Java Code">
                                                    </dx:ASPxMemo>
                                                    <dx:ASPxButton ID="btnGen" runat="server" Text="Parse" OnClick="btnGen_Click" Theme="Aqua"
                                                        Width="100px">
                                                    </dx:ASPxButton>
                                                    <br />
                                                    <br />
                                                    <table>
                                                        <tbody>
                                                            <tr>
                                                                <td>
                                                                    <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Class name" Font-Size="10pt">
                                                                    </dx:ASPxLabel>
                                                                    &nbsp;
                                                                </td>
                                                                <td>
                                                                    <dx:ASPxTextBox ID="txtClassName" runat="server" Theme="Aqua" Width="200px" Height="20px"
                                                                        Font-Size="12pt">
                                                                    </dx:ASPxTextBox>
                                                                </td>
                                                                <td>
                                                                    <dx:ASPxRadioButtonList ID="RadioButtonList" runat="server" EnableTheming="True"
                                                                        SelectedIndex="0" Theme="Aqua" ValueType="System.Boolean"
                                                                        RepeatDirection="Horizontal" RepeatLayout="Flow">
                                                                        <Items>
                                                                            <dx:ListEditItem Text="Activity" Value="True" Selected="True" />
                                                                            <dx:ListEditItem Text="View" Value="False" />
                                                                        </Items>
                                                                    </dx:ASPxRadioButtonList>
                                                                </td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </dx:SplitterContentControl>
                                            </ContentCollection>
                                        </dx:SplitterPane>
                                    </Panes>
                                </dx:ASPxSplitter>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                    <dx:TabPage Text="PARSE JSON">
                        <ActiveTabImage IconID="actions_convert_32x32">
                        </ActiveTabImage>
                        <TabImage IconID="actions_convert_32x32">
                        </TabImage>
                        <ContentCollection>
                            <dx:ContentControl ID="ContentControl2" runat="server">
                                <dx:ASPxSplitter ID="ASPxSplitter2" runat="server" Height="600px" Width="100%" Theme="Metropolis">
                                    <Panes>
                                        <dx:SplitterPane>
                                            <ContentCollection>
                                                <dx:SplitterContentControl ID="SplitterContentControl3" runat="server">
                                                    <dx:ASPxMemo ID="txtJson" runat="server" Height="500px" Width="100%" Theme="Aqua" ToolTip="Json Code">
                                                    </dx:ASPxMemo>
                                                    <dx:ASPxButton ID="btnClearJson" runat="server" Text="Clear"
                                                        Theme="Aqua" Width="100px" OnClick="btnClearJson_Click" />
                                                </dx:SplitterContentControl>
                                            </ContentCollection>
                                        </dx:SplitterPane>
                                        <dx:SplitterPane>
                                            <ContentCollection>
                                                <dx:SplitterContentControl ID="SplitterContentControl4" runat="server">
                                                    <dx:ASPxMemo ID="txtCodeParseJson" runat="server" Height="500px" Width="100%" Theme="Aqua" ToolTip="Java code">
                                                    </dx:ASPxMemo>
                                                    <dx:ASPxButton ID="btnParseJson" runat="server" Text="Parse" Theme="Aqua"
                                                        Width="100px" OnClick="btnParseJson_Click" />
                                                </dx:SplitterContentControl>
                                            </ContentCollection>
                                        </dx:SplitterPane>
                                    </Panes>
                                </dx:ASPxSplitter>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>
                </TabPages>
            </dx:ASPxPageControl>
        </div>

    </form>
</body>
<footer>
    <center>
<h5 class="auto-style1"><em>Android toolkit developed by Tuan Phong</em></h5>
</center>
</footer>
</html>
<noscript><title><style><layer><object><noscript >
