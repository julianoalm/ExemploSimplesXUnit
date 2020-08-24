using MyClasses;
using System;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace MyClassesTest
{
    public class FileProcessTest
    {        
        private string _GoodFileName;
        private const string BAD_FILE_NAME = @"C:\Regedit.exe";
        private readonly ITestOutputHelper _output;

        public FileProcessTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        [Trait("Owner", "Juliano")]
        [Description("Test to see if the file exist")]
        public void FileNameDoesExists()
        {
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            _GoodFileName = Utils.SetGoodFileName();

            _output.WriteLine($"Creating File: {_GoodFileName}"); // escreve no output do teste uma descrição
            File.AppendAllText(_GoodFileName, "Some Text");

            _output.WriteLine($"Testing File: {_GoodFileName}");
            fromCall = fileProcess.FileExists(_GoodFileName);

            _output.WriteLine($"Deleting File: {_GoodFileName}");
            File.Delete(_GoodFileName);

            Assert.True(fromCall, "The File exists.");
        }

        [Fact]
        [Trait("Owner", "Juliano")]
        [Description("Test to see if the file exist")]
        public void FileNameDoesExistsWithMessageFormatting()
        {
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            _GoodFileName = Utils.SetGoodFileName();

            _output.WriteLine($"Creating File: {_GoodFileName}"); // escreve no output do teste uma descrição
            File.AppendAllText(_GoodFileName, "Some Text");

            _output.WriteLine($"Testing File: {_GoodFileName}");
            fromCall = fileProcess.FileExists(_GoodFileName);

            _output.WriteLine($"Deleting File: {_GoodFileName}");
            File.Delete(_GoodFileName);

            Assert.True(fromCall, $"The {_GoodFileName} File exists.");
        }

        [Fact]
        [Trait("Owner", "Juliano")]
        [Description("Test to see if the file does not exist")]
        public void FileNameDoesNotExists()
        {
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            fromCall = fileProcess.FileExists(BAD_FILE_NAME);

            Assert.False(fromCall, "The File does not exists.");
        }

        [Fact]
        [Trait("Owner", "Davi")]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            FileProcess fileProcess = new FileProcess();
            
            Exception ex = Assert.Throws<ArgumentNullException>(() => fileProcess.FileExists(""));

            Assert.Equal("Value cannot be null.", ex.Message);
        }

        [Fact]
        [Trait("Owner", "Davi")]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException_UsingTryCatch()
        {
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            try
            {
                fromCall = fileProcess.FileExists("");
            }
            catch (ArgumentNullException)
            {
                //Isso foi sucesso!
                return;
            }

            Assert.True(fromCall, "Falha esperada");
        }
    }
}
