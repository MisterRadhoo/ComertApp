# ComertApp

Project PAW 
Designing your classes
The main classes in your project should be connected between them. An example is given below for the “Medical office” project, having the main classes Patient, Doctor and Prescription. In this case a Prescription is given by a certain Doctor to a certain Patient.

class Doctor
DoctorId
LastName
… other fields

class Patient
PatientId
LastName
… other fields

class Prescription
PrescriptionId
PatientId // The prescription is given to a certain patient
DoctorId // The prescription is given by a certain doctor
(optional) Patient // The Patient corresponding to the PatientId 
(optional) Doctor // The Doctor corresponding to the DoctorId
Date // Date on which the prescription has been issued
… other fields

Note: For some project topics there might be several good ways of defining the classes.
Designing your interface
The interface that you design should be easy and intuitive to use. Remember the quote “A user interface is like a joke. If you have to explain it, it’s not that good”. — Martin Leblanc .

Frequent mistakes:
●	Every time when a new prescription is issued, the application also creates a new doctor and a new patient;
●	When creating a new prescription, the user needs to manually type (or copy & paste) the Ids of the Patient and of the Doctor.

You should also make sure to choose the right control for each task as highlighted at https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/windows-forms-controls-by-function .


Tema:
Domeniu: Comert -> Clase: Magazin, Raion, Desfacere.
