using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DocumentView
{
    class dbIO
    {
        List<Member> memberList = new List<Member>();
        List<Game> gameList = new List<Game>();
        List<Movie> movieList = new List<Movie>();
        List<Transaction> transList = new List<Transaction>();

        OleDbConnection database;
        OleDbDataReader reader;

        int count = 0, count2 =0;
        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=VideoRental.mdb";

        public List<Member> getMembers()
        {
            memberList.Clear();

            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "SELECT * FROM Member";

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Member temp = new Member();

                    temp.Id = Int32.Parse(reader["ID"].ToString());
                    temp.FirstName = reader["FirstName"].ToString();
                    temp.LastName = reader["LastName"].ToString();
                    temp.StreetAddress = reader["Street"].ToString();
                    temp.City = reader["City"].ToString();
                    temp.State = reader["State"].ToString();
                    temp.ZipCode = reader["ZipCode"].ToString();
                    temp.Telephone = reader["PhoneNumber"].ToString();
                    temp.ExpirationDate = reader["CreditCardNumber"].ToString();
                    temp.CreditCard = reader["CreditCardExpDate"].ToString();
                    temp.CardType = reader["CreditCardType"].ToString();

                    memberList.Add(temp);
                }

                reader.Close();
                database.Close();
                return memberList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                reader.Close();
                database.Close();
                return memberList;
            }
        }

        public List<Game> getGames()
        {
            gameList.Clear();

            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "SELECT * FROM Game";

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Game temp = new Game();

                    temp.Id = Int32.Parse(reader["ID"].ToString());
                    temp.Title = reader["Title"].ToString();
                    temp.Description = reader["Description"].ToString();
                    temp.Publisher = reader["Publisher"].ToString();
                    temp.ReleaseDate = reader["ReleaseDate"].ToString();
                    temp.Rating = reader["Rating"].ToString();
                    temp.Price = Double.Parse(reader["PurchasePrice"].ToString());
                    temp.Copies = Int32.Parse(reader["Copies"].ToString());

                    gameList.Add(temp);
                }

                reader.Close();
                database.Close();
                return gameList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                reader.Close();
                database.Close();
                return gameList;
            }
        }

        public List<Movie> getMovies()
        {
            movieList.Clear();

            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "SELECT * FROM Movie";

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Movie temp = new Movie();

                    temp.Id = Int32.Parse(reader["ID"].ToString());
                    temp.Title = reader["Title"].ToString();
                    temp.Description = reader["Description"].ToString();
                    temp.Publisher = reader["Publisher"].ToString();
                    temp.ReleaseDate = reader["ReleaseDate"].ToString();
                    temp.Rating = reader["Rating"].ToString();
                    temp.Price = Double.Parse(reader["PurchasePrice"].ToString());
                    temp.Copies = Int32.Parse(reader["Copies"].ToString());

                    movieList.Add(temp);
                }

                reader.Close();
                database.Close();
                return movieList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                reader.Close();
                database.Close();
                return movieList;
            }
        }

        public List<Transaction> getTransactions()
        {
            transList.Clear();

            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "SELECT * FROM [Transaction]";

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Transaction temp = new Transaction();

                    temp.Id = Int32.Parse(reader["TransID"].ToString());
                    temp.MemberId = Int32.Parse(reader["MemberID"].ToString());
                    temp.FirstName = reader["FirstName"].ToString();
                    temp.LastName = reader["LastName"].ToString();
                    temp.RentDate = reader["RentDate"].ToString();
                    temp.DueDate = reader["DueDate"].ToString();
                    temp.ReturnDate = reader["ReturnDate"].ToString();
                    temp.Status = reader["Status"].ToString();
                    transList.Add(temp);
                }

                reader.Close();
                database.Close();
                return transList;
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
              reader.Close();
              database.Close();
              return transList;
            }
        }

        public void updateMovie(Movie obj)
        {
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "UPDATE Movie " +
                                     "SET Title = '" + obj.Title + "', Description = '" + obj.Description +
                                     "', Publisher = '" + obj.Publisher + "', ReleaseDate = '" + obj.ReleaseDate +
                                     "', Rating = '" + obj.Rating + "', PurchasePrice = " + obj.Price +
                                     ", Copies = " + obj.Copies +
                                     " WHERE ID = " + obj.Id;

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                count = cmd.ExecuteNonQuery();

                if (count >= 1)
                    MessageBox.Show(obj.Title + "'s record has been updated!");
                else
                    MessageBox.Show("Error: No movie by that title!");

                database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                database.Close();
            }
        }

        public void updateGame(Game obj)
        {
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "UPDATE Game " +
                                     "SET Title = '" +obj.Title+ "', Description = '" +obj.Description+
                                     "', Publisher = '" +obj.Publisher+ "', ReleaseDate = '" +obj.ReleaseDate+
                                     "', Rating = '" +obj.Rating+ "', PurchasePrice = " +obj.Price+
                                     ", Copies = " +obj.Copies+
                                     " WHERE ID = " +obj.Id;

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                count = cmd.ExecuteNonQuery();

                if (count >= 1)
                    MessageBox.Show(obj.Title + "'s record has been updated!");
                else
                    MessageBox.Show("Error: No game by that title!");

                database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                database.Close();
            }
        }

        public void updateMember(Member obj)
        {
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "UPDATE Member " +
                                     "SET FirstName = '" + obj.FirstName + "', LastName = '" + obj.LastName +
                                     "', Street = '" + obj.StreetAddress + "', City = '" + obj.City +
                                     "', ZipCode = '" + obj.ZipCode + "', PhoneNumber = '" + obj.Telephone +
                                     "', CreditCardNumber = '" + obj.CreditCard + "', CreditCardExpDate = '" + obj.ExpirationDate +
                                     "', CreditCardType = '" + obj.CardType +
                                     "' WHERE ID = " + obj.Id.ToString();

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                count = cmd.ExecuteNonQuery();

                if (count >= 1)
                    MessageBox.Show(obj.FirstName + " " + obj.LastName + "'s record has been updated!");
                else
                    MessageBox.Show("Error: No member with that ID!");

                database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                database.Close();
            }
        }

        public void addMovie(Movie obj, int num)
        {
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "INSERT INTO Movie (Title, Description, Publisher, ReleaseDate, Rating, PurchasePrice, Copies) " +
                                     "VALUES ('" + obj.Title + "', '" + obj.Description + "', '" + obj.Publisher + "', '" + obj.ReleaseDate + "', '" +
                                     obj.Rating + "', '" + obj.Price + "', '" + obj.Copies + "')";

                string queryString2 = "SELECT * FROM Movie WHERE Title = '" +obj.Title+ "'";

                string queryString3;

                OleDbCommand cmd = new OleDbCommand(queryString, database);
                OleDbCommand cmd2 = new OleDbCommand(queryString2, database);

                count = cmd.ExecuteNonQuery();

                reader = cmd2.ExecuteReader();

                Movie temp = new Movie();

                reader.Read();
                temp.Id = Int32.Parse(reader["ID"].ToString());
                temp.Title = reader["Title"].ToString();
                temp.Description = reader["Description"].ToString();
                temp.Publisher = reader["Publisher"].ToString();
                temp.ReleaseDate = reader["ReleaseDate"].ToString();
                temp.Rating = reader["Rating"].ToString();
                temp.Price = Double.Parse(reader["PurchasePrice"].ToString());
                temp.Copies = Int32.Parse(reader["Copies"].ToString());

                queryString3 = "INSERT INTO MovieCopy (CheckedOut, MovieID) " +
                                 "VALUES (false, '" + temp.Id + "')";
                
                OleDbCommand cmd3 = new OleDbCommand(queryString3, database);

                for (int i = 0; i < num; i++)
                    count2 = cmd3.ExecuteNonQuery();

                if (count >= 1)
                    MessageBox.Show(obj.Title + " has been added!");
                else
                    MessageBox.Show("Error: Could not add movie!");

                reader.Close();
                database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                reader.Close();
                database.Close();
            }
        }

        public void addGame(Game obj, int num)
        {
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "INSERT INTO Game (Title, Description, Publisher, ReleaseDate, Rating, PurchasePrice, Copies) " +
                                     "VALUES ('" + obj.Title + "', '" + obj.Description + "', '" + obj.Publisher + "', '" + obj.ReleaseDate + "', '" +
                                     obj.Rating + "', '" + obj.Price + "', '" + obj.Copies + "')";

                string queryString2 = "SELECT * FROM Game WHERE Title = '" + obj.Title + "'";

                string queryString3;

                OleDbCommand cmd = new OleDbCommand(queryString, database);
                OleDbCommand cmd2 = new OleDbCommand(queryString2, database);

                count = cmd.ExecuteNonQuery();

                reader = cmd2.ExecuteReader();

                Game temp = new Game();

                reader.Read();
                temp.Id = Int32.Parse(reader["ID"].ToString());
                temp.Title = reader["Title"].ToString();
                temp.Description = reader["Description"].ToString();
                temp.Publisher = reader["Publisher"].ToString();
                temp.ReleaseDate = reader["ReleaseDate"].ToString();
                temp.Rating = reader["Rating"].ToString();
                temp.Price = Double.Parse(reader["PurchasePrice"].ToString());
                temp.Copies = Int32.Parse(reader["Copies"].ToString());

                queryString3 = "INSERT INTO GameCopy (CheckedOut, GameID) " +
                                 "VALUES (false, '" + temp.Id + "')";

                OleDbCommand cmd3 = new OleDbCommand(queryString3, database);

                for (int i = 0; i < num; i++)
                    count2 = cmd3.ExecuteNonQuery();

                if (count >= 1)
                    MessageBox.Show(obj.Title + " has been added!");
                else
                    MessageBox.Show("Error: Could not add game!");

                reader.Close();
                database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                reader.Close();
                database.Close();
            }
        }

        public void addMember(Member obj)
        {
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "INSERT INTO Member (FirstName, LastName, Street, City, State, ZipCode, PhoneNumber, CreditCardNumber, CreditCardExpDate, CreditCardType) " +
                                     "VALUES ('" + obj.FirstName + "', '" + obj.LastName + "', '" + obj.StreetAddress + "', '" + obj.City + "', '" + obj.State + "', '" + obj.ZipCode +
                                     "', '" + obj.Telephone + "', '" + obj.CreditCard + "', '" + obj.ExpirationDate + "', '" + obj.CardType + "')";

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                count = cmd.ExecuteNonQuery();

                if (count >= 1)
                    MessageBox.Show(obj.FirstName + " " + obj.LastName + " has been added!");
                else
                    MessageBox.Show("Error: Could not add member!");

                database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                database.Close();
            }
        }

        public void deleteMovie(int id)
        {
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "DELETE FROM Movie WHERE ID = " +id.ToString();
                string queryString2 = "DELETE FROM MovieCopy WHERE MovieID = " +id.ToString();

                OleDbCommand cmd = new OleDbCommand(queryString, database);
                OleDbCommand cmd2 = new OleDbCommand(queryString2, database);

                count = cmd2.ExecuteNonQuery();
                count = cmd.ExecuteNonQuery();

                if (count >= 1)
                {
                    MessageBox.Show("Delete successful!");
                }
                else
                {
                    MessageBox.Show("No movie with that ID was found!");
                }

                database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                database.Close();
            }
        }

        public void deleteGame(int id)
        {
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "DELETE FROM Game WHERE ID = " + id.ToString();
                string queryString2 = "DELETE FROM GameCopy WHERE GameID = " + id.ToString();

                OleDbCommand cmd = new OleDbCommand(queryString, database);
                OleDbCommand cmd2 = new OleDbCommand(queryString2, database);

                count = cmd2.ExecuteNonQuery();
                count = cmd.ExecuteNonQuery();

                if (count >= 1)
                {
                    MessageBox.Show("Delete successful!");
                }
                else
                {
                    MessageBox.Show("No game with that ID was found!");
                }

                database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                database.Close();
            }
        }

        public void deleteMember(int id)
        {
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "DELETE FROM Member WHERE ID = " + id.ToString();

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                count = cmd.ExecuteNonQuery();

                if (count >= 1)
                {
                    MessageBox.Show("Delete successful!");
                }
                else
                {
                    MessageBox.Show("No member with that ID was found!");
                }

                database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                database.Close();
            }
        }

        public void rentGame(Transaction obj, int id)
        {
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "UPDATE GameCopy SET CheckedOut = true WHERE GameID = " +id.ToString()+ " AND CheckedOut = false";

                string queryString2 = "INSERT INTO [Transaction] (MemberID, FirstName, LastName, GameID, RentDate, DueDate, ReturnDate)" +
                                      " VALUES ('" + obj.Id + "', '" + obj.FirstName + "', '" + obj.LastName + "', '" + id + "', '" + obj.RentDate + "', '" + obj.DueDate + "', '" + obj.ReturnDate + "')";

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                OleDbCommand cmd2 = new OleDbCommand(queryString2, database);

                count = cmd.ExecuteNonQuery();

                cmd2.ExecuteNonQuery();

                if (count >= 1)
                    MessageBox.Show("Rent successful!");
                else
                    MessageBox.Show("Out of Stock!");

                database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                database.Close();
            }
        }

        public void rentMovie(Transaction obj, int id)
        {
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "UPDATE MovieCopy SET CheckedOut = true WHERE MovieID = " + id.ToString() + ", CheckedOut = false";

                string queryString2 = "INSERT INTO [Transaction] (MemberID, FirstName, LastName, MovieID, RentDate, DueDate, ReturnDate)" +
                                      " VALUES ('" + obj.Id + "', '" + obj.FirstName + "', '" + obj.LastName + "', '" + id + "', '" + obj.RentDate + "', '" + obj.DueDate + "', '" + obj.ReturnDate + "')";

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                OleDbCommand cmd2 = new OleDbCommand(queryString2, database);

                count = cmd.ExecuteNonQuery();

                cmd2.ExecuteNonQuery();

                if (count >= 1)
                    MessageBox.Show("Rent successful!");
                else
                    MessageBox.Show("Out of Stock!");

                database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                database.Close();
            }
        }

        public void returnMovie(Transaction obj, Int32 id)
        {
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "UPDATE MovieCopy SET CheckedOut = false WHERE MovieID = " + id.ToString() + ", CheckedOut = true";

                string queryString2 = "DELETE FROM [Transaction] WHERE MovieID = " + id.ToString() + ", MemberID = " + obj.MemberId.ToString();

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                OleDbCommand cmd2 = new OleDbCommand(queryString2, database);

                count = cmd.ExecuteNonQuery();

                cmd2.ExecuteNonQuery();

                if (count >= 1)
                    MessageBox.Show("Return successful!");
                else
                    MessageBox.Show("Error: Return unsuccessful!");

                database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                database.Close();
            }
        }

        public void returnGame(Transaction obj, int id)
        {
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "UPDATE GameCopy SET CheckedOut = false WHERE GameID = " + id.ToString() + ", CheckedOut = true FETCH FIRST 1 ROWS ONLY";

                string queryString2 = "DELETE FROM [Transaction] WHERE GameID = " + id.ToString() + ", MemberID = " + obj.MemberId.ToString();

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                OleDbCommand cmd2 = new OleDbCommand(queryString2, database);

                count = cmd.ExecuteNonQuery();

                cmd2.ExecuteNonQuery();

                if (count >= 1)
                    MessageBox.Show("Return successful!");
                else
                    MessageBox.Show("Error: Return unsuccessful!");

                database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                database.Close();
            }
        }

        public List<Game> searchGame(string name)
        {
            gameList.Clear();

            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "SELECT * FROM Game Where Title LIKE ('%" +name+ "%')";

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Game temp = new Game();

                    temp.Id =(Int32) reader["ID"];
                    temp.Title = reader["Title"].ToString();
                    temp.Description = reader["Description"].ToString();
                    temp.Publisher = reader["Publisher"].ToString();
                    temp.ReleaseDate = reader["ReleaseDate"].ToString();
                    temp.Rating = reader["Rating"].ToString();
                    temp.Price =(double) reader["PurchasePrice"];
                    temp.Copies =(Int32) reader["Copies"];

                    gameList.Add(temp);
                }

                reader.Close();
                database.Close();
                return gameList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                gameList.Clear();
                reader.Close();
                database.Close();
                return gameList;
            }
        }

        public List<Movie> searchMovie(string name)
        {
            movieList.Clear();

            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "SELECT * FROM Movie Where Title LIKE ('%" +name+ "%')";

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Movie temp = new Movie();

                    temp.Id =(Int32) reader["ID"];
                    temp.Title = reader["Title"].ToString();
                    temp.Description = reader["Description"].ToString();
                    temp.Publisher = reader["Publisher"].ToString();
                    temp.ReleaseDate = reader["ReleaseDate"].ToString();
                    temp.Rating = reader["Rating"].ToString();
                    temp.Price =(double) reader["PurchasePrice"];
                    temp.Copies =(Int32) reader["Copies"];

                    movieList.Add(temp);
                }

                reader.Close();
                database.Close();
                return movieList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                movieList.Clear();
                reader.Close();
                database.Close();
                return movieList;
            }
        }

        public Member findMember(int id)
        {
            Member temp = new Member();

            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "SELECT * FROM Member Where ID = " +id.ToString();

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    temp.Id = Int32.Parse(reader["ID"].ToString());
                    temp.FirstName = reader["FirstName"].ToString();
                    temp.LastName = reader["LastName"].ToString();
                    temp.StreetAddress = reader["Street"].ToString();
                    temp.City = reader["City"].ToString();
                    temp.State = reader["State"].ToString();
                    temp.ZipCode =reader["ZipCode"].ToString();
                    temp.Telephone = reader["PhoneNumber"].ToString();
                    temp.ExpirationDate = reader["CreditCardNumber"].ToString();
                    temp.CreditCard = reader["CreditCardExpDate"].ToString();
                    temp.CardType = reader["CreditCardType"].ToString();
                    reader.Close();
                    database.Close();
                    return temp;
                }

                MessageBox.Show("No member with that ID was found!");
                reader.Close();
                database.Close();
                return temp;               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                reader.Close();
                database.Close();
                return temp;
            }
        }

        public Transaction findTrans(int id)
        {
            Transaction temp = new Transaction();

            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();

                string queryString = "SELECT * FROM [Transaction] Where ID = " + id.ToString();

                OleDbCommand cmd = new OleDbCommand(queryString, database);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    temp.Id = Int32.Parse(reader["ID"].ToString());
                    temp.MemberId = Int32.Parse(reader["MemberID"].ToString());
                    temp.FirstName = reader["FirstName"].ToString();
                    temp.LastName = reader["LastName"].ToString();
                    temp.RentDate = reader["RentDate"].ToString();
                    temp.DueDate = reader["DueDate"].ToString();
                    temp.ReturnDate = reader["ReturnDate"].ToString();
                    temp.Status = reader["Status"].ToString();
                    reader.Close();
                    database.Close();
                    return temp;
                }

                MessageBox.Show("No transaction with that ID was found!");
                reader.Close();
                database.Close();
                return temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                reader.Close();
                database.Close();
                return temp;
            }
        }
    }
}