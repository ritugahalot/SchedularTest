namespace TestAppointment
{
    public class AppointmentGeneratorTest
    {
        [Fact]
        public void GenerateAppointments_ReturnsCorrectNumberOfWeeks()
        {
            // Arrange
            var names = new List<string> { "John", "Jane", "Bob" };
            int weeks = 3; 

            // Act
            var appointments = AppointmentGenerator.BookAppointments<string>(names);

            // Assert
            Assert.Equal(weeks, appointments.Count);
        }
    }
}