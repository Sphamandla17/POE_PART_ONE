using System;
using System.Media;
using POE_PART_ONE;

class Program
{
    static string userName = ""; // Store the user's name for personalization

    static void Main(string[] args)
    {
        // Display initial welcome and get user's name
        DisplayInitialWelcome();

        // Play greeting sound
        SoundEffect sound = new SoundEffect();
        sound.greeting();

        // Enter main menu loop
        bool continueRunning = true;
        while (continueRunning)
        {
            continueRunning = MainMenu();
        }
    }

    public static void DisplayInitialWelcome()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("============================================");
        Console.WriteLine("|        Welcome to Security Helper!        |");
        Console.WriteLine("============================================");
        Console.ResetColor();

        Console.Write("\nPlease enter your name: ");
        userName = Console.ReadLine();

        // Display personalized welcome with ASCII art
        DisplayWelcomeMessage();
    }

    public static void DisplayWelcomeMessage()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(@"  _____                          _   _       _     _ ");
        Console.WriteLine(@" / ____|                        | | | |     | |   | |");
        Console.WriteLine(@"| (___   ___ _ __ __ _ _ __   __| | | | ___ | |__ | |");
        Console.WriteLine(@" \___ \ / __| '__/ _` | '_ \ / _` | | |/ _ \| '_ \| |");
        Console.WriteLine(@" ____) | (__| | | (_| | | | | (_| | | | (_) | |_) |_|");
        Console.WriteLine(@"|_____/ \___|_|  \__,_|_| |_|\__,_| |_|\___/|_.__/(_)");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n============================================");
        Console.WriteLine($"|  Welcome, {userName}! How can we help you today?  |");
        Console.WriteLine("============================================");
        Console.ResetColor();

        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    public static bool MainMenu()
    {
        Console.Clear();

        // Set welcome message color
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("============================================");
        Console.WriteLine($"|           Hi {userName}, how can we help you?    |");
        Console.WriteLine("============================================");
        Console.ResetColor();
        Console.WriteLine();

        // Menu options in different colors
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Choose an option:");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1) EndToEndEncryption");
        Console.WriteLine("2) EducationAndAwareness");
        Console.WriteLine("3) AuthenticationAndAuthorization");
        Console.WriteLine("4) ProcessesAndProtocols");
        Console.WriteLine("5) Stop Music");
        Console.WriteLine("6) Exit");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\r\nSelect an option: ");
        Console.ResetColor();

        EndToEndEncryption1 encryption1 = new EndToEndEncryption1();
        Education edu = new Education();
        Authentication check = new Authentication();
        ProcessesAndProtocols rules = new ProcessesAndProtocols();

        switch (Console.ReadLine())
        {
            case "1":
                encryption1.EndToEndEncryption(); // Show the picture

                // Submenu for EndToEndEncryption
                string[] endToEndOptions = {
                "1. How it works",
                "2. Encryption algorithms",
                "3. Key exchange",
                "4. Implementation examples",
                "5. Back to main menu"
            };

                bool stayInSubmenu = true;
                while (stayInSubmenu)
                {
                    Console.WriteLine("\nEnd-to-End Encryption Options:");
                    foreach (string option in endToEndOptions)
                    {
                        Console.WriteLine(option);
                    }
                    Console.Write("Select a sub-option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("\nInformation about how end-to-end encryption works...");
                            break;
                        case "2":
                            Console.WriteLine("\nCommon encryption algorithms used: AES, RSA, etc...");
                            break;
                        case "3":
                            Console.WriteLine("\nKey exchange methods: Diffie-Hellman, etc...");
                            break;
                        case "4":
                            Console.WriteLine("\nImplementation examples in popular apps...");
                            break;
                        case "5":
                            stayInSubmenu = false;
                            break;
                        default:
                            Console.WriteLine("Invalid sub-option. Try again.");
                            break;
                    }

                    if (stayInSubmenu)
                    {
                        Console.WriteLine("\nPress Enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        encryption1.EndToEndEncryption(); // Show the picture again
                    }
                }
                return true;

            case "2":
                edu.Awareness();

                // Submenu for EducationAndAwareness
                string[] educationOptions = {
                "1. Security best practices",
                "2. Phishing awareness",
                "3. Password management",
                "4. Data protection",
                "5. Back to main menu"
            };

                stayInSubmenu = true;
                while (stayInSubmenu)
                {
                    Console.WriteLine("\nEducation and Awareness Options:");
                    foreach (string option in educationOptions)
                    {
                        Console.WriteLine(option);
                    }
                    Console.Write("Select a sub-option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("\nSecurity Best Practices:");
                            Console.WriteLine("- Use strong, unique passwords");
                            Console.WriteLine("- Enable two-factor authentication");
                            Console.WriteLine("- Keep software updated");
                            Console.WriteLine("- Be cautious with email attachments");
                            break;
                        case "2":
                            Console.WriteLine("\nPhishing Awareness:");
                            Console.WriteLine("- Don't click suspicious links");
                            Console.WriteLine("- Check sender email addresses");
                            Console.WriteLine("- Look for poor grammar/spelling");
                            Console.WriteLine("- Verify requests for sensitive info");
                            break;
                        case "3":
                            Console.WriteLine("\nPassword Management:");
                            Console.WriteLine("- Use a password manager");
                            Console.WriteLine("- Create long passphrases");
                            Console.WriteLine("- Don't reuse passwords");
                            Console.WriteLine("- Change passwords after breaches");
                            break;
                        case "4":
                            Console.WriteLine("\nData Protection:");
                            Console.WriteLine("- Encrypt sensitive data");
                            Console.WriteLine("- Regular backups");
                            Console.WriteLine("- Secure disposal of old devices");
                            Console.WriteLine("- Understand privacy policies");
                            break;
                        case "5":
                            stayInSubmenu = false;
                            break;
                        default:
                            Console.WriteLine("Invalid sub-option. Try again.");
                            break;
                    }

                    if (stayInSubmenu)
                    {
                        Console.WriteLine("\nPress Enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        edu.Awareness(); // Show the picture again
                    }
                }
                return true;

            case "3":
                check.Authorize();

                // Submenu for AuthenticationAndAuthorization
                string[] authOptions = {
                "1. Multi-factor authentication",
                "2. OAuth protocol",
                "3. Role-based access control",
                "4. Biometric authentication",
                "5. Back to main menu"
            };

                stayInSubmenu = true;
                while (stayInSubmenu)
                {
                    Console.WriteLine("\nAuthentication and Authorization Options:");
                    foreach (string option in authOptions)
                    {
                        Console.WriteLine(option);
                    }
                    Console.Write("Select a sub-option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("\nMulti-Factor Authentication:");
                            Console.WriteLine("- Requires multiple verification methods");
                            Console.WriteLine("- Typically: password + SMS/email code");
                            Console.WriteLine("- More secure than single-factor");
                            Console.WriteLine("- Common in banking and sensitive apps");
                            break;
                        case "2":
                            Console.WriteLine("\nOAuth Protocol:");
                            Console.WriteLine("- Standard for access delegation");
                            Console.WriteLine("- Allows limited access without sharing passwords");
                            Console.WriteLine("- Used by Google, Facebook, etc.");
                            Console.WriteLine("- OAuth 2.0 is current standard");
                            break;
                        case "3":
                            Console.WriteLine("\nRole-Based Access Control:");
                            Console.WriteLine("- Permissions based on user roles");
                            Console.WriteLine("- Example: Admin, Editor, Viewer");
                            Console.WriteLine("- Principle of least privilege");
                            Console.WriteLine("- Easier to manage than individual permissions");
                            break;
                        case "4":
                            Console.WriteLine("\nBiometric Authentication:");
                            Console.WriteLine("- Uses physical characteristics");
                            Console.WriteLine("- Fingerprint, Face ID, Iris scan");
                            Console.WriteLine("- Convenient but has privacy concerns");
                            Console.WriteLine("- Often used with other factors");
                            break;
                        case "5":
                            stayInSubmenu = false;
                            break;
                        default:
                            Console.WriteLine("Invalid sub-option. Try again.");
                            break;
                    }

                    if (stayInSubmenu)
                    {
                        Console.WriteLine("\nPress Enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        check.Authorize(); // Show the picture again
                    }
                }
                return true;

            case "4":
                rules.Protocols();

                // Submenu for ProcessesAndProtocols
                string[] protocolOptions = {
                "1. SSL/TLS",
                "2. HTTPS",
                "3. Secure file transfer",
                "4. VPN protocols",
                "5. Back to main menu"
            };

                stayInSubmenu = true;
                while (stayInSubmenu)
                {
                    Console.WriteLine("\nProcesses and Protocols Options:");
                    foreach (string option in protocolOptions)
                    {
                        Console.WriteLine(option);
                    }
                    Console.Write("Select a sub-option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("\nSSL/TLS Protocols:");
                            Console.WriteLine("- Secure communication protocols");
                            Console.WriteLine("- TLS 1.2 and 1.3 are current standards");
                            Console.WriteLine("- Used for HTTPS, email, VPNs");
                            Console.WriteLine("- Provides encryption and authentication");
                            break;
                        case "2":
                            Console.WriteLine("\nHTTPS:");
                            Console.WriteLine("- HTTP secured with SSL/TLS");
                            Console.WriteLine("- Encrypts all communication");
                            Console.WriteLine("- Uses port 443 by default");
                            Console.WriteLine("- Requires SSL certificate");
                            break;
                        case "3":
                            Console.WriteLine("\nSecure File Transfer:");
                            Console.WriteLine("- SFTP: SSH File Transfer Protocol");
                            Console.WriteLine("- SCP: Secure Copy Protocol");
                            Console.WriteLine("- FTPS: FTP over SSL");
                            Console.WriteLine("- Always prefer over unencrypted FTP");
                            break;
                        case "4":
                            Console.WriteLine("\nVPN Protocols:");
                            Console.WriteLine("- OpenVPN: Open source, highly configurable");
                            Console.WriteLine("- IPsec: Common in enterprise networks");
                            Console.WriteLine("- WireGuard: Modern, high-performance");
                            Console.WriteLine("- L2TP/IPsec: Common in older systems");
                            break;
                        case "5":
                            stayInSubmenu = false;
                            break;
                        default:
                            Console.WriteLine("Invalid sub-option. Try again.");
                            break;
                    }

                    if (stayInSubmenu)
                    {
                        Console.WriteLine("\nPress Enter to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        rules.Protocols(); // Show the picture again
                    }
                }
                return true;

            case "6":
                Console.WriteLine("Exit");
                return false;

            default:
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
                return true;
        }
    }
}