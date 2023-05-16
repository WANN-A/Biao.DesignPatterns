/*************************************************************************************
 *
 * 文 件 名：	CompositePattern.cs
 * 描 述：   组合模式
 *
 * 版 本：	v1.0
 * 创 建 者：	BiaoWang
 * 创 建 时 间：	2023/5/16 17:21
 * 
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biao.DesignPatterns.StructuralPatterns
{
    /// <summary>
    /// 创建 Employee 类，该类带有 Employee 对象的列表。
    /// </summary>
    public class Employee
    {
        private string name;
        private string description;
        private int salary;
        private List<Employee> subordinates;

        public Employee(string name, string description, int salary)
        {
            this.name = name;
            this.description = description;
            this.salary = salary;
            subordinates = new List<Employee>();
        }

        public void Add(Employee e)
        {
            subordinates.Add(e);
        }

        public void Remove(Employee e)
        {
            subordinates.Remove(e);
        }

        public List<Employee> GetSubordinates()
        {
            return subordinates;
        }

        public override string? ToString()
        {
            return $"Employee :[ Name :{name}, description :{description}, salary :{salary} ]";
        }
    }
}
