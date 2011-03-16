﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 6/10/2010 11:59:04
namespace Watermarker
{
    
    /// <summary>
    /// There are no comments for WatermarkerEntities in the schema.
    /// </summary>
    public partial class WatermarkerEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new WatermarkerEntities object using the connection string found in the 'WatermarkerEntities' section of the application configuration file.
        /// </summary>
        public WatermarkerEntities() : 
                base("name=WatermarkerEntities", "WatermarkerEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new WatermarkerEntities object.
        /// </summary>
        public WatermarkerEntities(string connectionString) : 
                base(connectionString, "WatermarkerEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new WatermarkerEntities object.
        /// </summary>
        public WatermarkerEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "WatermarkerEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Watermarks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<Watermark> Watermarks
        {
            get
            {
                if ((this._Watermarks == null))
                {
                    this._Watermarks = base.CreateQuery<Watermark>("[Watermarks]");
                }
                return this._Watermarks;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<Watermark> _Watermarks;
        /// <summary>
        /// There are no comments for Watermarks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddToWatermarks(Watermark watermark)
        {
            base.AddObject("Watermarks", watermark);
        }
    }
    /// <summary>
    /// There are no comments for WatermarkerModel.Watermark in the schema.
    /// </summary>
    /// <KeyProperties>
    /// GUID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="WatermarkerModel", Name="Watermark")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Watermark : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Watermark object.
        /// </summary>
        /// <param name="gUID">Initial value of GUID.</param>
        /// <param name="createdDate">Initial value of CreatedDate.</param>
        /// <param name="originalDir">Initial value of OriginalDir.</param>
        /// <param name="watermarkDir">Initial value of WatermarkDir.</param>
        /// <param name="modifiedDate">Initial value of ModifiedDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static Watermark CreateWatermark(global::System.Guid gUID, global::System.DateTime createdDate, string originalDir, string watermarkDir, global::System.DateTime modifiedDate)
        {
            Watermark watermark = new Watermark();
            watermark.GUID = gUID;
            watermark.CreatedDate = createdDate;
            watermark.OriginalDir = originalDir;
            watermark.WatermarkDir = watermarkDir;
            watermark.ModifiedDate = modifiedDate;
            return watermark;
        }
        /// <summary>
        /// There are no comments for property GUID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Guid GUID
        {
            get
            {
                return this._GUID;
            }
            set
            {
                this.OnGUIDChanging(value);
                this.ReportPropertyChanging("GUID");
                this._GUID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("GUID");
                this.OnGUIDChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Guid _GUID;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnGUIDChanging(global::System.Guid value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnGUIDChanged();
        /// <summary>
        /// There are no comments for property CreatedDate in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.DateTime CreatedDate
        {
            get
            {
                return this._CreatedDate;
            }
            set
            {
                this.OnCreatedDateChanging(value);
                this.ReportPropertyChanging("CreatedDate");
                this._CreatedDate = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("CreatedDate");
                this.OnCreatedDateChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.DateTime _CreatedDate;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnCreatedDateChanging(global::System.DateTime value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnCreatedDateChanged();
        /// <summary>
        /// There are no comments for property OriginalDir in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string OriginalDir
        {
            get
            {
                return this._OriginalDir;
            }
            set
            {
                this.OnOriginalDirChanging(value);
                this.ReportPropertyChanging("OriginalDir");
                this._OriginalDir = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("OriginalDir");
                this.OnOriginalDirChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _OriginalDir;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnOriginalDirChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnOriginalDirChanged();
        /// <summary>
        /// There are no comments for property WatermarkDir in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string WatermarkDir
        {
            get
            {
                return this._WatermarkDir;
            }
            set
            {
                this.OnWatermarkDirChanging(value);
                this.ReportPropertyChanging("WatermarkDir");
                this._WatermarkDir = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("WatermarkDir");
                this.OnWatermarkDirChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _WatermarkDir;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnWatermarkDirChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnWatermarkDirChanged();
        /// <summary>
        /// There are no comments for property OriginalHash in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string OriginalHash
        {
            get
            {
                return this._OriginalHash;
            }
            set
            {
                this.OnOriginalHashChanging(value);
                this.ReportPropertyChanging("OriginalHash");
                this._OriginalHash = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("OriginalHash");
                this.OnOriginalHashChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _OriginalHash;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnOriginalHashChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnOriginalHashChanged();
        /// <summary>
        /// There are no comments for property ModifiedDate in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this.OnModifiedDateChanging(value);
                this.ReportPropertyChanging("ModifiedDate");
                this._ModifiedDate = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.DateTime _ModifiedDate;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnModifiedDateChanging(global::System.DateTime value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnModifiedDateChanged();
    }
}
