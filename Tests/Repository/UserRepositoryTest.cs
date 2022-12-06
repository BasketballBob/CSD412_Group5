using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using System;
using GroupAssignment.Models;
using GroupAssignment.Models.Repositories;

namespace DatabaseUnitTests
{
    [TestClass]
    public class UserRepositoryTest
    {
        private User NewUser(string email, string password)
        {
            User newUser = new User();
            newUser.Email = email;
            newUser.Password = password;
            return newUser;
        }

        [TestMethod]
        public void TestGetUser()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DatabaseContext>().UseInMemoryDatabase("TestDatabase").Options;

            var context = new DatabaseContext(options);

            User testUser = NewUser("TestEmail@gleep.com", "passwordTest");
            context.Users.Add(testUser);

            context.SaveChanges();

            var repository = new UserRepository(context);

            // Act
            var result = repository.GetUser(testUser.Id);

            // Assert
            Assert.AreEqual(testUser, result);
        }

        [TestMethod]
        public void TestGetUserFail()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DatabaseContext>().UseInMemoryDatabase("TestDatabase").Options;

            var context = new DatabaseContext(options);

            User testUser = NewUser("TestEmail@gleep.com", "passwordTest");

            context.SaveChanges();

            var repository = new UserRepository(context);

            // Act
            var result = repository.GetUser(testUser.Id);

            // Assert
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void TestUpdateUser()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DatabaseContext>().UseInMemoryDatabase("TestDatabase").Options;

            var context = new DatabaseContext(options);

            User testUser = NewUser("TestEmail@gleep.com", "passwordTest");
            context.Users.Add(testUser);

            context.SaveChanges();

            var repository = new UserRepository(context);

            // Act
            testUser.Email = "newemail.com";
            var result = repository.UpdateUser(testUser);

            // Assert
            Assert.AreEqual(testUser, result);
        }

        [TestMethod]
        public void TestDeleteUser()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DatabaseContext>().UseInMemoryDatabase("TestDatabase").Options;

            var context = new DatabaseContext(options);

            User testUser = NewUser("TestEmail@gleep.com", "passwordTest");
            context.Users.Add(testUser);

            context.SaveChanges();

            var repository = new UserRepository(context);

            // Act
            repository.DeleteUser(testUser);
            var result = repository.GetUser(testUser.Id);

            // Assert
            Assert.AreEqual(null, result);
        }
    }
}
