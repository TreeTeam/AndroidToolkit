using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Summary description for parseJson
/// </summary>
public class parseJson
{
    Dictionary<string, object> dic;
    string newLine = "\r\n";
    string txt;
    List<string> listNode = new List<string>();
    List<string> listNode_arr = new List<string>();
    JavaScriptSerializer js = new JavaScriptSerializer();

	public parseJson()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string parse(string Json)
    {
        try
        {
            dic = js.Deserialize<Dictionary<string, object>>(Json);

            foreach (KeyValuePair<string, object> item in dic)
            {
                string s = item.Value.ToString();
            }

        }
        catch (Exception ex)
        {
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='javaScript'>alert('Hey boss! Error when read json code')</SCRIPT>");
            return "";
        }

        txt = "JSONObject root = new JSONObject(str);" + newLine;
        Build(dic, "root");
        return txt;
    }


    int checkListNode(string str)
    {
        int numb = 0;
        foreach (string temp in listNode)
        {
            if (temp == str)
                numb++;
        }
        return numb;
    }

    int checkListNode_arr(string str)
    {
        int numb = 0;
        foreach (string temp in listNode_arr)
        {
            if (temp == str)
                numb++;
        }
        return numb;
    }

    public void Build(Dictionary<string, object> dictionary, string root)
    {


        foreach (KeyValuePair<string, object> item in dictionary)
        {
            string type = item.Value.ToString();


            if (type.IndexOf("Dictionary") != -1 || type.IndexOf("ArrayList") != -1)
            {
                if (type.IndexOf("Dictionary") != -1)
                {
                    dictionary = (Dictionary<string, object>)item.Value;

                    int numb = checkListNode("obj_" + item.Key);
                    if (numb == 0)
                    {
                        listNode.Add("obj_" + item.Key);
                        txt += "JSONObject obj_" + item.Key + " = MyJson.getNode(" + root + ", \"" + item.Key + "\");" + newLine;
                        Build(dictionary, "obj_" + item.Key);
                    }
                    else
                    {
                        listNode.Add("obj_" + item.Key);
                        txt += "JSONObject obj_" + item.Key + "_" + numb + " = MyJson.getNode(" + root + ", \"" + item.Key + "\");" + newLine;
                        Build(dictionary, "obj_" + item.Key + "_" + numb);
                    }


                }
                if (type.IndexOf("ArrayList") != -1)
                {
                    ArrayList list = (ArrayList)item.Value;

                    int numb = checkListNode("arr_" + item.Key);
                    if (numb == 0)
                    {
                        listNode.Add("arr_" + item.Key);
                        txt += newLine + "JSONArray arr_" + item.Key + " = MyJson.getArray(" + root + ", \"" + item.Key + "\");" + newLine;
                        BuildArray(list, "arr_" + item.Key);
                    }
                    else
                    {
                        listNode.Add("arr_" + item.Key);
                        txt += newLine + "JSONArray arr_" + item.Key + "_" + numb + " = MyJson.getArray(" + root + ", \"" + item.Key + "\");" + newLine;
                        BuildArray(list, "arr_" + item.Key + "_" + numb);
                    }


                }
            }
            else
            {

                int temp;
                if (int.TryParse(item.Value.ToString(), out temp))
                {
                    txt += "\t// = MyJson.getInt(" + root + ", \"" + item.Key + "\" );" + newLine;
                }
                else
                {
                    if (item.Value.ToString().ToUpper() == "FALSE" || item.Value.ToString().ToUpper() == "TRUE")
                    {
                        txt += "\t// = MyJson.getBoolean(" + root + ", \"" + item.Key + "\" );" + newLine;
                    }
                    else
                    {
                        txt += "\t// = MyJson.getString(" + root + ", \"" + item.Key + "\" );" + newLine;
                    }
                }

            }
        }
    }

    public void BuildArray(ArrayList arr, string root)
    {

        txt += "for( int i=0; i < " + root + ".length(); i++ ) { " + newLine + "// temp model" + newLine;

        try
        {
            Dictionary<string, object> dictionary = (Dictionary<string, object>)arr[0];

            txt += "JSONObject obj_temp = " + root + ".getJSONObject(i);" + newLine;



            foreach (KeyValuePair<string, object> item in dictionary)
            {
                string type = item.Value.ToString();


                if (type.IndexOf("Dictionary") != -1 || type.IndexOf("ArrayList") != -1)
                {
                    if (type.IndexOf("Dictionary") != -1)
                    {
                        Dictionary<string, object> _dictionary = (Dictionary<string, object>)item.Value;

                        int numb = checkListNode_arr("obj_" + item.Key);
                        if (numb == 0)
                        {
                            listNode_arr.Add("obj_" + item.Key);
                            txt += "JSONObject obj_" + item.Key + " = MyJson.getNode(" + "obj_temp" + ", \"" + item.Key + "\");" + newLine;
                            Build(_dictionary, "obj_" + item.Key);
                        }
                        else
                        {
                            listNode_arr.Add("obj_" + item.Key);
                            txt += "JSONObject obj_" + item.Key + "_" + numb + " = MyJson.getNode(" + "obj_temp" + ", \"" + item.Key + "\");" + newLine;
                            Build(_dictionary, "obj_" + item.Key + "_" + numb);
                        }


                    }
                    if (type.IndexOf("ArrayList") != -1)
                    {
                        ArrayList list = (ArrayList)item.Value;

                        int numb = checkListNode("arr_" + item.Key);
                        if (numb == 0)
                        {
                            listNode.Add("arr_" + item.Key);
                            txt += newLine + "JSONArray arr_" + item.Key + " = MyJson.getArray(" + "obj_temp" + ", \"" + item.Key + "\");" + newLine;
                            BuildArray(list, "arr_" + item.Key);

                        }
                        else
                        {
                            listNode.Add("arr_" + item.Key);
                            txt += newLine + "JSONArray arr_" + item.Key + "_" + numb + " = MyJson.getArray(" + "obj_temp" + ", \"" + item.Key + "\");" + newLine;
                            BuildArray(list, "arr_" + item.Key + "_" + numb);
                        }


                    }
                }
                else
                {
                    txt += "\t// = MyJson.getString(" + "obj_temp" + ", \"" + item.Key + "\");" + newLine;
                }
            }
        }
        catch
        {
            // do something

        }



        txt += "// add list" + newLine + "}" + newLine;
    }
}