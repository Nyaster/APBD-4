using System;

namespace LegacyApp;

public interface IUserCreditService
{
    internal int GetCreditLimit(string lastName, DateTime dateOfBirth);
}