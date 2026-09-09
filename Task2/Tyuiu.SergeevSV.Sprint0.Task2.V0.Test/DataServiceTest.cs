using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SergeevSV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SergeevSV.Sprint0.Task2.V0.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckGetMessageValid()
    {
        string name = "Степан";
        string expected = "Привет, Степан";

        string res = DataService.GetMessage(name);

        Assert.AreEqual(expected, res);
    }
}