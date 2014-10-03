using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace AndroidTookit
{
    public partial class Default : System.Web.UI.Page
    {
        List<controlModel> lsControl = new List<controlModel>();
        XmlDocument doc = new XmlDocument();
        const string mActivity = "a";
        const string mView = "v";
        string parentView = "";


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtXML.Text = "";
        }

        protected void btnGen_Click(object sender, EventArgs e)
        {
            try
            {
                doc.LoadXml(txtXML.Text);
                getTextView();
                getLinearLayout();
                getListView();
                getImageView();
                getRelativeLayout();
                getFrameLayout();
                getEditText();

                TableLayout();
                TableRow();
                GridLayout();
                GridView();
                ScrollView();
                HorizontalScrollView();
                WebView();
                ExpandableListView();
                Spinner();
                AutoCompleteTextView();
                MultiAutoCompleteTextView();
                Button();
                SeekBar();
                ProgressBar();
                ViewFlipper();


            }
            catch (Exception ex)
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='javaScript'>alert('Hey boss! Error when read XML.')</SCRIPT>");
                return;
            }

            if (lsControl.Count == 0)
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='javaScript'>alert('Hey boss! Can not parse.')</SCRIPT>");
                return;
            }

            if (txtClassName.Text.Length == 0)
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='javaScript'>alert('Hey boss! Please fill in class name.')</SCRIPT>");
                return;
            }

            txtView.Text = "";
            txtView.Text += "package com.appscyclone.view;\r\n\r\n";

            if ((bool)RadioButtonList.SelectedItem.Value)
            {
                txtView.Text += "import android.app.Activity;\r\n";
            }

            txtView.Text += "import android.view.View;\r\n";

            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.TEXTVIEW)
                {
                    txtView.Text += "import android.widget.TextView;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.LINEARLAYOUT)
                {
                    txtView.Text += "import android.widget.LinearLayout;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.LISTVIEW)
                {
                    txtView.Text += "import android.widget.ListView;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.IMAGEVIEW)
                {
                    txtView.Text += "import android.widget.ImageView;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.RELATIVELAYOUT)
                {
                    txtView.Text += "import android.widget.RelativeLayout;\r\n";
                    break;
                }
            }

            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.FRAMELAYOUT)
                {
                    txtView.Text += "import android.widget.FrameLayout;\r\n";
                    break;
                }
            }

            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.EDITTEXT)
                {
                    txtView.Text += "import android.widget.EditText;\r\n";
                    break;
                }
            }



            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.TABLELAYOUT)
                {
                    txtView.Text += "import android.widget.TableLayout;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.TABLEROW)
                {
                    txtView.Text += "import android.widget.TableRow;\r\n";
                    break;
                }
            }

            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.GRIDLAYOUT)
                {
                    txtView.Text += "import android.widget.GridLayout;\r\n";
                    break;
                }
            }

            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.GRIDVIEW)
                {
                    txtView.Text += "import android.widget.GridView;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.SCROLLVIEW)
                {
                    txtView.Text += "import android.widget.ScrollView;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.HORIZONTALSCROLLVIEW)
                {
                    txtView.Text += "import android.widget.HorizontalScrollView;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.WEBVIEW)
                {
                    txtView.Text += "import android.webkit.WebView;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.EXPANDABLELISTVIEW)
                {
                    txtView.Text += "import android.widget.ExpandableListView;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.SPINNER)
                {
                    txtView.Text += "import android.widget.Spinner;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.AUTOCOMPLETETEXTVIEW)
                {
                    txtView.Text += "import android.widget.AutoCompleteTextView;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.MULTIAUTOCOMPLETETEXTVIEW)
                {
                    txtView.Text += "import android.widget.MultiAutoCompleteTextView;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.BUTTON)
                {
                    txtView.Text += "import android.widget.Button;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.SEEKBAR)
                {
                    txtView.Text += "import android.widget.SeekBar;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.PROGRESSBAR)
                {
                    txtView.Text += "import android.widget.ProgressBar;\r\n";
                    break;
                }
            }
            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.VIEWFLIPPER)
                {
                    txtView.Text += "import android.widget.ViewFlipper;\r\n";
                    break;
                }
            }




            txtView.Text += "\r\n\r\n";
            txtView.Text += "public class " + txtClassName.Text + " {\r\n\r\n";

            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.TEXTVIEW)
                {
                    txtView.Text += "\tpublic TextView " + lsControl[i].Name + ";\r\n";
                }

                if (lsControl[i].Type == KeyWord.LINEARLAYOUT)
                {
                    txtView.Text += "\tpublic LinearLayout " + lsControl[i].Name + ";\r\n";
                }

                if (lsControl[i].Type == KeyWord.LISTVIEW)
                {
                    txtView.Text += "\tpublic ListView " + lsControl[i].Name + ";\r\n";
                }

                if (lsControl[i].Type == KeyWord.FRAMELAYOUT)
                {
                    txtView.Text += "\tpublic FrameLayout " + lsControl[i].Name + ";\r\n";
                }

                if (lsControl[i].Type == KeyWord.IMAGEVIEW)
                {
                    txtView.Text += "\tpublic ImageView " + lsControl[i].Name + ";\r\n";
                }

                if (lsControl[i].Type == KeyWord.RELATIVELAYOUT)
                {
                    txtView.Text += "\tpublic RelativeLayout " + lsControl[i].Name + ";\r\n";
                }

                if (lsControl[i].Type == KeyWord.EDITTEXT)
                {
                    txtView.Text += "\tpublic EditText " + lsControl[i].Name + ";\r\n";
                }

                if (lsControl[i].Type == KeyWord.TABLELAYOUT)
                {
                    txtView.Text += "\tpublic TableLayout " + lsControl[i].Name + ";\r\n";
                }
                if (lsControl[i].Type == KeyWord.TABLEROW)
                {
                    txtView.Text += "\tpublic TableRow " + lsControl[i].Name + ";\r\n";
                }
                if (lsControl[i].Type == KeyWord.GRIDLAYOUT)
                {
                    txtView.Text += "\tpublic GridLayout " + lsControl[i].Name + ";\r\n";
                }
                if (lsControl[i].Type == KeyWord.GRIDVIEW)
                {
                    txtView.Text += "\tpublic GridView " + lsControl[i].Name + ";\r\n";
                }
                if (lsControl[i].Type == KeyWord.SCROLLVIEW)
                {
                    txtView.Text += "\tpublic ScrollView " + lsControl[i].Name + ";\r\n";
                }
                if (lsControl[i].Type == KeyWord.HORIZONTALSCROLLVIEW)
                {
                    txtView.Text += "\tpublic HorizontalScrollView " + lsControl[i].Name + ";\r\n";
                }
                if (lsControl[i].Type == KeyWord.WEBVIEW)
                {
                    txtView.Text += "\tpublic WebView " + lsControl[i].Name + ";\r\n";
                }
                if (lsControl[i].Type == KeyWord.EXPANDABLELISTVIEW)
                {
                    txtView.Text += "\tpublic ExpandableListView " + lsControl[i].Name + ";\r\n";
                }
                if (lsControl[i].Type == KeyWord.SPINNER)
                {
                    txtView.Text += "\tpublic Spinner " + lsControl[i].Name + ";\r\n";
                }
                if (lsControl[i].Type == KeyWord.AUTOCOMPLETETEXTVIEW)
                {
                    txtView.Text += "\tpublic AutoCompleteTextView " + lsControl[i].Name + ";\r\n";
                }
                if (lsControl[i].Type == KeyWord.MULTIAUTOCOMPLETETEXTVIEW)
                {
                    txtView.Text += "\tpublic MultiAutoCompleteTextView " + lsControl[i].Name + ";\r\n";
                }
                if (lsControl[i].Type == KeyWord.BUTTON)
                {
                    txtView.Text += "\tpublic Button " + lsControl[i].Name + ";\r\n";
                }
                if (lsControl[i].Type == KeyWord.SEEKBAR)
                {
                    txtView.Text += "\tpublic SeekBar " + lsControl[i].Name + ";\r\n";
                }
                if (lsControl[i].Type == KeyWord.PROGRESSBAR)
                {
                    txtView.Text += "\tpublic ProgressBar " + lsControl[i].Name + ";\r\n";
                }
                if (lsControl[i].Type == KeyWord.VIEWFLIPPER)
                {
                    txtView.Text += "\tpublic ViewFlipper " + lsControl[i].Name + ";\r\n";
                }


            }

            if ((bool)RadioButtonList.SelectedItem.Value)
            {
                txtView.Text += "\tprivate Activity mActivity;\r\n";
                txtView.Text += "\r\n\tpublic " + txtClassName.Text + " (Activity a) {\r\n\r\n";
                txtView.Text += "\t\tmActivity = a;\r\n";
                parentView = mActivity;
            }
            else
            {
                txtView.Text += "\r\n\tpublic " + txtClassName.Text + " (View v) {\r\n\r\n";
                parentView = mView;
            }


            for (int i = 0; i < lsControl.Count; i++)
            {
                if (lsControl[i].Type == KeyWord.TEXTVIEW)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (TextView) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }

                if (lsControl[i].Type == KeyWord.LINEARLAYOUT)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (LinearLayout) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }

                if (lsControl[i].Type == KeyWord.LISTVIEW)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (ListView) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }

                if (lsControl[i].Type == KeyWord.FRAMELAYOUT)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (FrameLayout) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }

                if (lsControl[i].Type == KeyWord.IMAGEVIEW)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (ImageView) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }

                if (lsControl[i].Type == KeyWord.RELATIVELAYOUT)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (RelativeLayout) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.EDITTEXT)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (EditText) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.TABLELAYOUT)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (TableLayout) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.TABLEROW)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (TableRow) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.GRIDLAYOUT)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (GridLayout) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.GRIDVIEW)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (GridView) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.SCROLLVIEW)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (ScrollView) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.HORIZONTALSCROLLVIEW)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (HorizontalScrollView) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.WEBVIEW)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (WebView) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.EXPANDABLELISTVIEW)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (ExpandableListView) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.SPINNER)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (Spinner) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.AUTOCOMPLETETEXTVIEW)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (AutoCompleteTextView) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.MULTIAUTOCOMPLETETEXTVIEW)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (MultiAutoCompleteTextView) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.BUTTON)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (Button) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.SEEKBAR)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (SeekBar) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.PROGRESSBAR)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (ProgressBar) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }
                if (lsControl[i].Type == KeyWord.VIEWFLIPPER)
                {
                    txtView.Text += "\t\t" + lsControl[i].Name + " = (ViewFlipper) " + parentView + ".findViewById(R.id." + lsControl[i].Name + ");\r\n";
                }

            }

            txtView.Text += "\r\n\t}\r\n}";

        }


        void getTextView()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("TextView");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 't')
                    {
                        lsControl.Add(new controlModel(KeyWord.TEXTVIEW, temp));
                    }
                }
                catch (Exception ex)
                { }
            }
        }


        void getLinearLayout()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("LinearLayout");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'l')
                    {
                        lsControl.Add(new controlModel(KeyWord.LINEARLAYOUT, temp));
                    }
                }
                catch (Exception ex)
                { }

            }
        }

        void getListView()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("ListView");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'l')
                    {
                        lsControl.Add(new controlModel(KeyWord.LISTVIEW, temp));
                    }
                }
                catch (Exception ex)
                { }

            }
        }


        void getImageView()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("ImageView");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'i')
                    {
                        lsControl.Add(new controlModel(KeyWord.IMAGEVIEW, temp));
                    }
                }
                catch (Exception ex)
                { }

            }
        }


        void getRelativeLayout()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("RelativeLayout");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'r')
                    {
                        lsControl.Add(new controlModel(KeyWord.RELATIVELAYOUT, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void getFrameLayout()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("FrameLayout");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'f')
                    {
                        lsControl.Add(new controlModel(KeyWord.FRAMELAYOUT, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void getEditText()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("EditText");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'e')
                    {
                        lsControl.Add(new controlModel(KeyWord.EDITTEXT, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void TableLayout()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("TableLayout");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 't')
                    {
                        lsControl.Add(new controlModel(KeyWord.TABLELAYOUT, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void TableRow()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("TableRow");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 't')
                    {
                        lsControl.Add(new controlModel(KeyWord.TABLEROW, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void GridLayout()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("GridLayout");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'g')
                    {
                        lsControl.Add(new controlModel(KeyWord.GRIDLAYOUT, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void GridView()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("GridView");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'g')
                    {
                        lsControl.Add(new controlModel(KeyWord.GRIDVIEW, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void ScrollView()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("ScrollView");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 's')
                    {
                        lsControl.Add(new controlModel(KeyWord.SCROLLVIEW, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void HorizontalScrollView()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("HorizontalScrollView");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'h')
                    {
                        lsControl.Add(new controlModel(KeyWord.HORIZONTALSCROLLVIEW, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void WebView()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("WebView");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'w')
                    {
                        lsControl.Add(new controlModel(KeyWord.WEBVIEW, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void ExpandableListView()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("ExpandableListView");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'e')
                    {
                        lsControl.Add(new controlModel(KeyWord.EXPANDABLELISTVIEW, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void Spinner()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("Spinner");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 's')
                    {
                        lsControl.Add(new controlModel(KeyWord.SPINNER, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void AutoCompleteTextView()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("AutoCompleteTextView");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'a')
                    {
                        lsControl.Add(new controlModel(KeyWord.AUTOCOMPLETETEXTVIEW, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void MultiAutoCompleteTextView()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("MultiAutoCompleteTextView");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'm')
                    {
                        lsControl.Add(new controlModel(KeyWord.MULTIAUTOCOMPLETETEXTVIEW, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void Button()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("Button");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'b')
                    {
                        lsControl.Add(new controlModel(KeyWord.BUTTON, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void SeekBar()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("SeekBar");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 's')
                    {
                        lsControl.Add(new controlModel(KeyWord.SEEKBAR, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void ProgressBar()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("ProgressBar");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'p')
                    {
                        lsControl.Add(new controlModel(KeyWord.PROGRESSBAR, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }

        void ViewFlipper()
        {
            XmlNodeList xnList = doc.GetElementsByTagName("ViewFlipper");
            foreach (XmlNode xn in xnList)
            {
                try
                {
                    string temp = xn.Attributes.GetNamedItem("android:id").Value;
                    temp = temp.Remove(0, 5);
                    if (temp[0] == 'v')
                    {
                        lsControl.Add(new controlModel(KeyWord.VIEWFLIPPER, temp));
                    }
                }
                catch (Exception ex)
                { }


            }
        }
        protected void btnClearJson_Click(object sender, EventArgs e)
        {
            txtJson.Text = "";
        }
        protected void btnParseJson_Click(object sender, EventArgs e)
        {
            parseJson parse = new parseJson();
            txtCodeParseJson.Text = parse.parse(txtJson.Text);
        }
    }
}