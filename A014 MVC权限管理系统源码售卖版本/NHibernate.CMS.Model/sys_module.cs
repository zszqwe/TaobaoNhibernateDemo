//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NHibernate.CMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial  class sys_module
    {
        public  virtual int moduleID { get; set; }
        public  virtual string moduleKey { get; set; }
        public  virtual string moduleName { get; set; }
        public  virtual int parentID { get; set; }
        public  virtual string urls { get; set; }
        public  virtual bool isMenu { get; set; }
        public  virtual bool isDisplay { get; set; }
        public  virtual int sort { get; set; }
        public  virtual string icon { get; set; }
        public  virtual int class_layer { get; set; }
    }
}
