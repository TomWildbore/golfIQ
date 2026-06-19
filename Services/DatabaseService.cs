using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using golfIQ.Models;

namespace golfIQ.Services;

public class DatabaseService
{
    private SQLiteAsyncConnection? _database;

    public async Task Init()
    {
        if (_database != null)
            return;

        string dbPath = Path.Combine(
            FileSystem.AppDataDirectory,
            "golfiq.db3");

        _database = new SQLiteAsyncConnection(dbPath);

        await _database.CreateTableAsync<Round>();
    }

    public async Task<List<Round>> GetRoundsAsync()
    {
        await Init();
        return await _database!.Table<Round>().ToListAsync();
    }

    public async Task AddRoundAsync(Round round)
    {
        await Init();
        await _database!.InsertAsync(round);
    }

    public async Task DeleteRoundAsync(Round round)
    {
        await Init();
        await _database!.DeleteAsync(round);
    }
}