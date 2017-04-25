﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection
Imports Lab10LINQ

<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="std5830203856")> _
Partial Public Class DataClassesStudentDataContext
    Inherits System.Data.Linq.DataContext

    Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()

#Region "Extensibility Method Definitions"
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub InsertDepartment(instance As Department)
    End Sub
    Partial Private Sub UpdateDepartment(instance As Department)
    End Sub
    Partial Private Sub DeleteDepartment(instance As Department)
    End Sub
    Partial Private Sub InsertSubject(instance As Subject)
    End Sub
    Partial Private Sub UpdateSubject(instance As Subject)
    End Sub
    Partial Private Sub DeleteSubject(instance As Subject)
    End Sub
    Partial Private Sub InsertEnroll(instance As Enroll)
    End Sub
    Partial Private Sub UpdateEnroll(instance As Enroll)
    End Sub
    Partial Private Sub DeleteEnroll(instance As Enroll)
    End Sub
    Partial Private Sub InsertStudent(instance As Student)
    End Sub
    Partial Private Sub UpdateStudent(instance As Student)
    End Sub
    Partial Private Sub DeleteStudent(instance As Student)
    End Sub
#End Region

    Public Sub New()
        MyBase.New(Global.Lab10LINQ.My.MySettings.Default.std5830203856ConnectionString, mappingSource)
        OnCreated
    End Sub

    Public Sub New(ByVal connection As String)
        MyBase.New(connection, mappingSource)
        OnCreated
    End Sub

    Public Sub New(ByVal connection As System.Data.IDbConnection)
        MyBase.New(connection, mappingSource)
        OnCreated
    End Sub

    Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
        MyBase.New(connection, mappingSource)
        OnCreated
    End Sub

    Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
        MyBase.New(connection, mappingSource)
        OnCreated
    End Sub

    Public ReadOnly Property Departments() As System.Data.Linq.Table(Of Department)
        Get
            Return Me.GetTable(Of Department)
        End Get
    End Property

    Public ReadOnly Property Subjects() As System.Data.Linq.Table(Of Subject)
        Get
            Return Me.GetTable(Of Subject)
        End Get
    End Property

    Public ReadOnly Property Enrolls() As System.Data.Linq.Table(Of Enroll)
        Get
            Return Me.GetTable(Of Enroll)
        End Get
    End Property

    Public ReadOnly Property Students() As System.Data.Linq.Table(Of Student)
        Get
            Return Me.GetTable(Of Student)
        End Get
    End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Department")> _
Partial Public Class Department
    Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged

    Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)

    Private _dept_id As String

    Private _dept_name As String

    Private _Students As EntitySet(Of Student)

#Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub Ondept_idChanging(value As String)
    End Sub
    Partial Private Sub Ondept_idChanged()
    End Sub
    Partial Private Sub Ondept_nameChanging(value As String)
    End Sub
    Partial Private Sub Ondept_nameChanged()
    End Sub
#End Region

    Public Sub New()
        MyBase.New
        Me._Students = New EntitySet(Of Student)(AddressOf Me.attach_Students, AddressOf Me.detach_Students)
        OnCreated
    End Sub

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_dept_id", DbType:="NChar(2) NOT NULL", CanBeNull:=False, IsPrimaryKey:=True)> _
    Public Property dept_id() As String
        Get
            Return Me._dept_id
        End Get
        Set
            If (String.Equals(Me._dept_id, Value) = False) Then
                Me.Ondept_idChanging(Value)
                Me.SendPropertyChanging
                Me._dept_id = Value
                Me.SendPropertyChanged("dept_id")
                Me.Ondept_idChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_dept_name", DbType:="VarChar(50)")> _
    Public Property dept_name() As String
        Get
            Return Me._dept_name
        End Get
        Set
            If (String.Equals(Me._dept_name, Value) = False) Then
                Me.Ondept_nameChanging(Value)
                Me.SendPropertyChanging
                Me._dept_name = Value
                Me.SendPropertyChanged("dept_name")
                Me.Ondept_nameChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Department_Student", Storage:="_Students", ThisKey:="dept_id", OtherKey:="dept_id")> _
    Public Property Students() As EntitySet(Of Student)
        Get
            Return Me._Students
        End Get
        Set
            Me._Students.Assign(Value)
        End Set
    End Property

    Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging

    Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub SendPropertyChanging()
        If ((Me.PropertyChangingEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
        End If
    End Sub

    Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
        If ((Me.PropertyChangedEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End If
    End Sub

    Private Sub attach_Students(ByVal entity As Student)
        Me.SendPropertyChanging
        entity.Department = Me
    End Sub

    Private Sub detach_Students(ByVal entity As Student)
        Me.SendPropertyChanging
        entity.Department = Nothing
    End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Subject")> _
Partial Public Class Subject
    Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged

    Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)

    Private _subj_id As String

    Private _subj_name As String

    Private _unit As System.Nullable(Of Integer)

    Private _Enrolls As EntitySet(Of Enroll)

#Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub Onsubj_idChanging(value As String)
    End Sub
    Partial Private Sub Onsubj_idChanged()
    End Sub
    Partial Private Sub Onsubj_nameChanging(value As String)
    End Sub
    Partial Private Sub Onsubj_nameChanged()
    End Sub
    Partial Private Sub OnunitChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnunitChanged()
    End Sub
#End Region

    Public Sub New()
        MyBase.New
        Me._Enrolls = New EntitySet(Of Enroll)(AddressOf Me.attach_Enrolls, AddressOf Me.detach_Enrolls)
        OnCreated
    End Sub

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_subj_id", DbType:="NChar(6) NOT NULL", CanBeNull:=False, IsPrimaryKey:=True)> _
    Public Property subj_id() As String
        Get
            Return Me._subj_id
        End Get
        Set
            If (String.Equals(Me._subj_id, Value) = False) Then
                Me.Onsubj_idChanging(Value)
                Me.SendPropertyChanging
                Me._subj_id = Value
                Me.SendPropertyChanged("subj_id")
                Me.Onsubj_idChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_subj_name", DbType:="VarChar(50)")> _
    Public Property subj_name() As String
        Get
            Return Me._subj_name
        End Get
        Set
            If (String.Equals(Me._subj_name, Value) = False) Then
                Me.Onsubj_nameChanging(Value)
                Me.SendPropertyChanging
                Me._subj_name = Value
                Me.SendPropertyChanged("subj_name")
                Me.Onsubj_nameChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_unit", DbType:="Int")> _
    Public Property unit() As System.Nullable(Of Integer)
        Get
            Return Me._unit
        End Get
        Set
            If (Me._unit.Equals(Value) = False) Then
                Me.OnunitChanging(Value)
                Me.SendPropertyChanging
                Me._unit = Value
                Me.SendPropertyChanged("unit")
                Me.OnunitChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Subject_Enroll", Storage:="_Enrolls", ThisKey:="subj_id", OtherKey:="subj_id")> _
    Public Property Enrolls() As EntitySet(Of Enroll)
        Get
            Return Me._Enrolls
        End Get
        Set
            Me._Enrolls.Assign(Value)
        End Set
    End Property

    Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging

    Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub SendPropertyChanging()
        If ((Me.PropertyChangingEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
        End If
    End Sub

    Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
        If ((Me.PropertyChangedEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End If
    End Sub

    Private Sub attach_Enrolls(ByVal entity As Enroll)
        Me.SendPropertyChanging
        entity.Subject = Me
    End Sub

    Private Sub detach_Enrolls(ByVal entity As Enroll)
        Me.SendPropertyChanging
        entity.Subject = Nothing
    End Sub

    Public Shared Widening Operator CType(v As Subject) As Subject
        Throw New NotImplementedException()
    End Operator
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Enroll")> _
Partial Public Class Enroll
    Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged

    Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)

    Private _subj_id As String

    Private _std_id As String

    Private _term As System.Nullable(Of Integer)

    Private _academic_year As Integer

    Private _Subject As EntityRef(Of Subject)

    Private _Student As EntityRef(Of Student)

#Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub Onsubj_idChanging(value As String)
    End Sub
    Partial Private Sub Onsubj_idChanged()
    End Sub
    Partial Private Sub Onstd_idChanging(value As String)
    End Sub
    Partial Private Sub Onstd_idChanged()
    End Sub
    Partial Private Sub OntermChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OntermChanged()
    End Sub
    Partial Private Sub Onacademic_yearChanging(value As Integer)
    End Sub
    Partial Private Sub Onacademic_yearChanged()
    End Sub
#End Region

    Public Sub New()
        MyBase.New
        Me._Subject = CType(Nothing, EntityRef(Of Subject))
        Me._Student = CType(Nothing, EntityRef(Of Student))
        OnCreated
    End Sub

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_subj_id", DbType:="NChar(6) NOT NULL", CanBeNull:=False, IsPrimaryKey:=True)> _
    Public Property subj_id() As String
        Get
            Return Me._subj_id
        End Get
        Set
            If (String.Equals(Me._subj_id, Value) = False) Then
                If Me._Subject.HasLoadedOrAssignedValue Then
                    Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
                End If
                Me.Onsubj_idChanging(Value)
                Me.SendPropertyChanging
                Me._subj_id = Value
                Me.SendPropertyChanged("subj_id")
                Me.Onsubj_idChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_std_id", DbType:="NChar(11) NOT NULL", CanBeNull:=False, IsPrimaryKey:=True)> _
    Public Property std_id() As String
        Get
            Return Me._std_id
        End Get
        Set
            If (String.Equals(Me._std_id, Value) = False) Then
                If Me._Student.HasLoadedOrAssignedValue Then
                    Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
                End If
                Me.Onstd_idChanging(Value)
                Me.SendPropertyChanging
                Me._std_id = Value
                Me.SendPropertyChanged("std_id")
                Me.Onstd_idChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_term", DbType:="Int")> _
    Public Property term() As System.Nullable(Of Integer)
        Get
            Return Me._term
        End Get
        Set
            If (Me._term.Equals(Value) = False) Then
                Me.OntermChanging(Value)
                Me.SendPropertyChanging
                Me._term = Value
                Me.SendPropertyChanged("term")
                Me.OntermChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_academic_year", DbType:="Int NOT NULL", IsPrimaryKey:=True)> _
    Public Property academic_year() As Integer
        Get
            Return Me._academic_year
        End Get
        Set
            If ((Me._academic_year = Value) _
                        = False) Then
                Me.Onacademic_yearChanging(Value)
                Me.SendPropertyChanging
                Me._academic_year = Value
                Me.SendPropertyChanged("academic_year")
                Me.Onacademic_yearChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Subject_Enroll", Storage:="_Subject", ThisKey:="subj_id", OtherKey:="subj_id", IsForeignKey:=True)> _
    Public Property Subject() As Subject
        Get
            Return Me._Subject.Entity
        End Get
        Set
            Dim previousValue As Subject = Me._Subject.Entity
            If ((Object.Equals(previousValue, Value) = False) _
                        OrElse (Me._Subject.HasLoadedOrAssignedValue = False)) Then
                Me.SendPropertyChanging
                If ((previousValue Is Nothing) _
                            = False) Then
                    Me._Subject.Entity = Nothing
                    previousValue.Enrolls.Remove(Me)
                End If
                Me._Subject.Entity = Value
                If ((Value Is Nothing) _
                            = False) Then
                    Value.Enrolls.Add(Me)
                    Me._subj_id = Value.subj_id
                Else
                    Me._subj_id = CType(Nothing, String)
                End If
                Me.SendPropertyChanged("Subject")
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Student_Enroll", Storage:="_Student", ThisKey:="std_id", OtherKey:="std_id", IsForeignKey:=True)> _
    Public Property Student() As Student
        Get
            Return Me._Student.Entity
        End Get
        Set
            Dim previousValue As Student = Me._Student.Entity
            If ((Object.Equals(previousValue, Value) = False) _
                        OrElse (Me._Student.HasLoadedOrAssignedValue = False)) Then
                Me.SendPropertyChanging
                If ((previousValue Is Nothing) _
                            = False) Then
                    Me._Student.Entity = Nothing
                    previousValue.Enrolls.Remove(Me)
                End If
                Me._Student.Entity = Value
                If ((Value Is Nothing) _
                            = False) Then
                    Value.Enrolls.Add(Me)
                    Me._std_id = Value.std_id
                Else
                    Me._std_id = CType(Nothing, String)
                End If
                Me.SendPropertyChanged("Student")
            End If
        End Set
    End Property

    Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging

    Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub SendPropertyChanging()
        If ((Me.PropertyChangingEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
        End If
    End Sub

    Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
        If ((Me.PropertyChangedEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End If
    End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Student")> _
Partial Public Class Student
    Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged

    Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)

    Private _std_id As String

    Private _std_name As String

    Private _std_lastname As String

    Private _dept_id As String

    Private _std_address As String

    Private _email As String

    Private _tel As String

    Private _Enrolls As EntitySet(Of Enroll)

    Private _Department As EntityRef(Of Department)

#Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub Onstd_idChanging(value As String)
    End Sub
    Partial Private Sub Onstd_idChanged()
    End Sub
    Partial Private Sub Onstd_nameChanging(value As String)
    End Sub
    Partial Private Sub Onstd_nameChanged()
    End Sub
    Partial Private Sub Onstd_lastnameChanging(value As String)
    End Sub
    Partial Private Sub Onstd_lastnameChanged()
    End Sub
    Partial Private Sub Ondept_idChanging(value As String)
    End Sub
    Partial Private Sub Ondept_idChanged()
    End Sub
    Partial Private Sub Onstd_addressChanging(value As String)
    End Sub
    Partial Private Sub Onstd_addressChanged()
    End Sub
    Partial Private Sub OnemailChanging(value As String)
    End Sub
    Partial Private Sub OnemailChanged()
    End Sub
    Partial Private Sub OntelChanging(value As String)
    End Sub
    Partial Private Sub OntelChanged()
    End Sub
#End Region

    Public Sub New()
        MyBase.New
        Me._Enrolls = New EntitySet(Of Enroll)(AddressOf Me.attach_Enrolls, AddressOf Me.detach_Enrolls)
        Me._Department = CType(Nothing, EntityRef(Of Department))
        OnCreated
    End Sub

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_std_id", DbType:="NChar(11) NOT NULL", CanBeNull:=False, IsPrimaryKey:=True)> _
    Public Property std_id() As String
        Get
            Return Me._std_id
        End Get
        Set
            If (String.Equals(Me._std_id, Value) = False) Then
                Me.Onstd_idChanging(Value)
                Me.SendPropertyChanging
                Me._std_id = Value
                Me.SendPropertyChanged("std_id")
                Me.Onstd_idChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_std_name", DbType:="VarChar(50)")> _
    Public Property std_name() As String
        Get
            Return Me._std_name
        End Get
        Set
            If (String.Equals(Me._std_name, Value) = False) Then
                Me.Onstd_nameChanging(Value)
                Me.SendPropertyChanging
                Me._std_name = Value
                Me.SendPropertyChanged("std_name")
                Me.Onstd_nameChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_std_lastname", DbType:="VarChar(50)")> _
    Public Property std_lastname() As String
        Get
            Return Me._std_lastname
        End Get
        Set
            If (String.Equals(Me._std_lastname, Value) = False) Then
                Me.Onstd_lastnameChanging(Value)
                Me.SendPropertyChanging
                Me._std_lastname = Value
                Me.SendPropertyChanged("std_lastname")
                Me.Onstd_lastnameChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_dept_id", DbType:="NChar(2)")> _
    Public Property dept_id() As String
        Get
            Return Me._dept_id
        End Get
        Set
            If (String.Equals(Me._dept_id, Value) = False) Then
                If Me._Department.HasLoadedOrAssignedValue Then
                    Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
                End If
                Me.Ondept_idChanging(Value)
                Me.SendPropertyChanging
                Me._dept_id = Value
                Me.SendPropertyChanged("dept_id")
                Me.Ondept_idChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_std_address", DbType:="VarChar(50)")> _
    Public Property std_address() As String
        Get
            Return Me._std_address
        End Get
        Set
            If (String.Equals(Me._std_address, Value) = False) Then
                Me.Onstd_addressChanging(Value)
                Me.SendPropertyChanging
                Me._std_address = Value
                Me.SendPropertyChanged("std_address")
                Me.Onstd_addressChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_email", DbType:="VarChar(50)")> _
    Public Property email() As String
        Get
            Return Me._email
        End Get
        Set
            If (String.Equals(Me._email, Value) = False) Then
                Me.OnemailChanging(Value)
                Me.SendPropertyChanging
                Me._email = Value
                Me.SendPropertyChanged("email")
                Me.OnemailChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_tel", DbType:="Char(10)")> _
    Public Property tel() As String
        Get
            Return Me._tel
        End Get
        Set
            If (String.Equals(Me._tel, Value) = False) Then
                Me.OntelChanging(Value)
                Me.SendPropertyChanging
                Me._tel = Value
                Me.SendPropertyChanged("tel")
                Me.OntelChanged
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Student_Enroll", Storage:="_Enrolls", ThisKey:="std_id", OtherKey:="std_id")> _
    Public Property Enrolls() As EntitySet(Of Enroll)
        Get
            Return Me._Enrolls
        End Get
        Set
            Me._Enrolls.Assign(Value)
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Department_Student", Storage:="_Department", ThisKey:="dept_id", OtherKey:="dept_id", IsForeignKey:=True)> _
    Public Property Department() As Department
        Get
            Return Me._Department.Entity
        End Get
        Set
            Dim previousValue As Department = Me._Department.Entity
            If ((Object.Equals(previousValue, Value) = False) _
                        OrElse (Me._Department.HasLoadedOrAssignedValue = False)) Then
                Me.SendPropertyChanging
                If ((previousValue Is Nothing) _
                            = False) Then
                    Me._Department.Entity = Nothing
                    previousValue.Students.Remove(Me)
                End If
                Me._Department.Entity = Value
                If ((Value Is Nothing) _
                            = False) Then
                    Value.Students.Add(Me)
                    Me._dept_id = Value.dept_id
                Else
                    Me._dept_id = CType(Nothing, String)
                End If
                Me.SendPropertyChanged("Department")
            End If
        End Set
    End Property

    Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging

    Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub SendPropertyChanging()
        If ((Me.PropertyChangingEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
        End If
    End Sub

    Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
        If ((Me.PropertyChangedEvent Is Nothing) _
                    = False) Then
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End If
    End Sub

    Private Sub attach_Enrolls(ByVal entity As Enroll)
        Me.SendPropertyChanging
        entity.Student = Me
    End Sub

    Private Sub detach_Enrolls(ByVal entity As Enroll)
        Me.SendPropertyChanging
        entity.Student = Nothing
    End Sub
End Class