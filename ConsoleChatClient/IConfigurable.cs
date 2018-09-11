﻿namespace ConsoleChat
{
    public interface IConfigurable
    {
        dynamic Initialize();
        IConfigurable Load();
        void Reset();
        void Save();
    }
}