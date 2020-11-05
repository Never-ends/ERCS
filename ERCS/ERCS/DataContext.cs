using ERCS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using WalkingTec.Mvvm.Core;

namespace ERCS//用于生成对应数据库表，以及索引
{
    public class DataContext : FrameworkContext
    {
        public DbSet<Virus> Viruses {  get; set; }//生成病毒表
        public DbSet<City> Cities { get; set; }//生成城市表
        public DbSet<Hospital> Hospitals { get; set; }//生成医院表
        public DbSet<ControlCenter> ControlCenter { get; set; }//生成疾控中心表
        public DbSet<Patient> Patients { get; set; }//生成病人表
        public DbSet<Report> Reports { get; set; }//生成记录病人状况表

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasIndex(x => x.IdNumber);//指定病人身份证号的索引

            base.OnModelCreating(modelBuilder);
        }

        public DataContext(CS cs)
             : base(cs)
        {
        }

        public DataContext(string cs, DBTypeEnum dbtype)
             : base(cs, dbtype)
        {
        }

    }

    /// <summary>
    /// 为EF的Migration准备的辅助类，填写完整连接字符串和数据库类型
    /// 就可以使用Add-Migration和Update-Database了
    /// </summary>
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            return new DataContext("你的完整连接字符串", DBTypeEnum.SqlServer);
        }
    }

}
