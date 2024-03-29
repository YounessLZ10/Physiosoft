USE [Physiosoft_DB]
GO

-- Inserting Physiotherapists 
INSERT INTO [dbo].[PHYSIOS] ([firstname], [lastname], [telephone]) VALUES
('John', 'Doe', '2101234567'),
('Jane', 'Smith', '2101234568'),
('Emily', 'Johnson', '2101234569'),
('Michael', 'Brown', '2101234570'),
('Sarah', 'Davis', '2101234571');

-- Inserting Patients
INSERT INTO [dbo].[PATIENTS] ([firstname], [lastname], [telephone], [address], [ssn], [has_reviewed], [patient_issue]) VALUES
('Alex', 'Taylor', '2107654321', '123 Main St', '123456789', 0, 'Back Pain'),
('Chris', 'Miller', '2107654322', '456 Elm St', '987654321', 0, 'Knee Injury'),
('Pat', 'White', '2107654323', '789 Oak St', '192837465', 0, 'Shoulder Pain'),
('Jordan', 'Harris', '2107654324', '321 Pine St', '564738291', 0, 'Ankle Sprain'),
('Casey', 'Martin', '2107654325', '654 Maple St', '837465192', 0, 'Wrist Fracture');

-- Inserting Appointments
INSERT INTO [dbo].[APPOINTMENTS] ([patient_id], [physio_id], [appointment_date], [duration_minutes], [appointment_status], [patient_issue], [has_scans]) VALUES
(1, 1, '2023-12-25 10:00:00', 60, 'Scheduled', 'Back Pain', 0),
(2, 2, '2023-12-26 11:00:00', 45, 'Scheduled', 'Knee Injury', 1),
(3, 3, '2023-12-27 09:30:00', 30, 'Scheduled', 'Shoulder Pain', 0);

-- Inserting Users (2 entries, 1 admin and 1 regular user)
INSERT INTO [dbo].[USERS] ([username], [password], [email], [is_admin]) VALUES
('adminUser', 'password123', 'admin@example.com', 1), -- Admin user
('regularUser', 'password123', 'user@example.com', 0); -- Regular user
