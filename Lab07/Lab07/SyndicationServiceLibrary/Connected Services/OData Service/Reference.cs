﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 18-Nov-24 10:25:52 PM
namespace Lab06
{
    
    /// <summary>
    /// There are no comments for StudentsModel in the schema.
    /// </summary>
    public partial class StudentsModel : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new StudentsModel object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public StudentsModel(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for note in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<note> note
        {
            get
            {
                if ((this._note == null))
                {
                    this._note = base.CreateQuery<note>("note");
                }
                return this._note;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<note> _note;
        /// <summary>
        /// There are no comments for student in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<student> student
        {
            get
            {
                if ((this._student == null))
                {
                    this._student = base.CreateQuery<student>("student");
                }
                return this._student;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<student> _student;
        /// <summary>
        /// There are no comments for note in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddTonote(note note)
        {
            base.AddObject("note", note);
        }
        /// <summary>
        /// There are no comments for student in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddTostudent(student student)
        {
            base.AddObject("student", student);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private const string ModelPart0 = "<edmx:Edmx Version=\"1.0\" xmlns:edmx=\"http://schemas.microsoft.com/ado/2007/06/edm" +
                "x\"><edmx:DataServices m:DataServiceVersion=\"1.0\" m:MaxDataServiceVersion=\"3.0\" x" +
                "mlns:m=\"http://schemas.microsoft.com/ado/2007/08/dataservices/metadata\"><Schema " +
                "Namespace=\"Lab06\" xmlns=\"http://schemas.microsoft.com/ado/2009/11/edm\"><EntityTy" +
                "pe Name=\"note\"><Key><PropertyRef Name=\"id\" /></Key><Property Name=\"id\" Type=\"Edm" +
                ".Int32\" Nullable=\"false\" p6:StoreGeneratedPattern=\"Identity\" xmlns:p6=\"http://sc" +
                "hemas.microsoft.com/ado/2009/02/edm/annotation\" /><Property Name=\"stud_id\" Type=" +
                "\"Edm.Int32\" /><Property Name=\"subject\" Type=\"Edm.String\" MaxLength=\"Max\" FixedLe" +
                "ngth=\"false\" Unicode=\"true\" /><Property Name=\"note1\" Type=\"Edm.Int32\" /><Navigat" +
                "ionProperty Name=\"student\" Relationship=\"Lab06.student_note\" ToRole=\"student_not" +
                "e_Source\" FromRole=\"student_note_Target\" /></EntityType><EntityType Name=\"studen" +
                "t\"><Key><PropertyRef Name=\"id\" /></Key><Property Name=\"id\" Type=\"Edm.Int32\" Null" +
                "able=\"false\" p6:StoreGeneratedPattern=\"Identity\" xmlns:p6=\"http://schemas.micros" +
                "oft.com/ado/2009/02/edm/annotation\" /><Property Name=\"name\" Type=\"Edm.String\" Ma" +
                "xLength=\"Max\" FixedLength=\"false\" Unicode=\"true\" /><NavigationProperty Name=\"not" +
                "e\" Relationship=\"Lab06.student_note\" ToRole=\"student_note_Target\" FromRole=\"stud" +
                "ent_note_Source\" /></EntityType><Association Name=\"student_note\"><End Type=\"Lab0" +
                "6.student\" Role=\"student_note_Source\" Multiplicity=\"0..1\" /><End Type=\"Lab06.not" +
                "e\" Role=\"student_note_Target\" Multiplicity=\"*\" /><ReferentialConstraint><Princip" +
                "al Role=\"student_note_Source\"><PropertyRef Name=\"id\" /></Principal><Dependent Ro" +
                "le=\"student_note_Target\"><PropertyRef Name=\"stud_id\" /></Dependent></Referential" +
                "Constraint></Association><EntityContainer Name=\"StudentsModel\" m:IsDefaultEntity" +
                "Container=\"true\"><EntitySet Name=\"note\" EntityType=\"Lab06.note\" /><EntitySet Nam" +
                "e=\"student\" EntityType=\"Lab06.student\" /><AssociationSet Name=\"student_note\" Ass" +
                "ociation=\"Lab06.student_note\"><End Role=\"student_note_Target\" EntitySet=\"note\" /" +
                "><End Role=\"student_note_Source\" EntitySet=\"student\" /></AssociationSet></Entity" +
                "Container></Schema></edmx:DataServices></edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static string GetConcatenatedEdmxString()
            {
                return string.Concat(ModelPart0);
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            public static global::Microsoft.Data.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel LoadModelFromString()
            {
                string edmxToParse = GetConcatenatedEdmxString();
                global::System.Xml.XmlReader reader = CreateXmlReader(edmxToParse);
                try
                {
                    return global::Microsoft.Data.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for Lab06.note in the schema.
    /// </summary>
    /// <KeyProperties>
    /// id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("note")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("id")]
    public partial class note : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new note object.
        /// </summary>
        /// <param name="ID">Initial value of id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static note Createnote(int ID)
        {
            note note = new note();
            note.id = ID;
            return note;
        }
        /// <summary>
        /// There are no comments for Property id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                this.OnidChanging(value);
                this._id = value;
                this.OnidChanged();
                this.OnPropertyChanged("id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _id;
        partial void OnidChanging(int value);
        partial void OnidChanged();
        /// <summary>
        /// There are no comments for Property stud_id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> stud_id
        {
            get
            {
                return this._stud_id;
            }
            set
            {
                this.Onstud_idChanging(value);
                this._stud_id = value;
                this.Onstud_idChanged();
                this.OnPropertyChanged("stud_id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _stud_id;
        partial void Onstud_idChanging(global::System.Nullable<int> value);
        partial void Onstud_idChanged();
        /// <summary>
        /// There are no comments for Property subject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string subject
        {
            get
            {
                return this._subject;
            }
            set
            {
                this.OnsubjectChanging(value);
                this._subject = value;
                this.OnsubjectChanged();
                this.OnPropertyChanged("subject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _subject;
        partial void OnsubjectChanging(string value);
        partial void OnsubjectChanged();
        /// <summary>
        /// There are no comments for Property note1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> note1
        {
            get
            {
                return this._note1;
            }
            set
            {
                this.Onnote1Changing(value);
                this._note1 = value;
                this.Onnote1Changed();
                this.OnPropertyChanged("note1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _note1;
        partial void Onnote1Changing(global::System.Nullable<int> value);
        partial void Onnote1Changed();
        /// <summary>
        /// There are no comments for student in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public student student
        {
            get
            {
                return this._student;
            }
            set
            {
                this._student = value;
                this.OnPropertyChanged("student");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private student _student;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Lab06.student in the schema.
    /// </summary>
    /// <KeyProperties>
    /// id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("student")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("id")]
    public partial class student : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new student object.
        /// </summary>
        /// <param name="ID">Initial value of id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static student Createstudent(int ID)
        {
            student student = new student();
            student.id = ID;
            return student;
        }
        /// <summary>
        /// There are no comments for Property id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                this.OnidChanging(value);
                this._id = value;
                this.OnidChanged();
                this.OnPropertyChanged("id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _id;
        partial void OnidChanging(int value);
        partial void OnidChanged();
        /// <summary>
        /// There are no comments for Property name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this.OnnameChanging(value);
                this._name = value;
                this.OnnameChanged();
                this.OnPropertyChanged("name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _name;
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        /// <summary>
        /// There are no comments for note in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<note> note
        {
            get
            {
                return this._note;
            }
            set
            {
                this._note = value;
                this.OnPropertyChanged("note");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<note> _note = new global::System.Data.Services.Client.DataServiceCollection<note>(null, global::System.Data.Services.Client.TrackingMode.None);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
