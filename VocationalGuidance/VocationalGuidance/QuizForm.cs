using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ApplicationForMissingAnimals.mainform;

namespace ApplicationForMissingAnimals
{
    
    public partial class QuizForm : Form
    {
        public string classname;
        public string username;
        public int score = 0;
     
        public QuizForm()
        {

            InitializeComponent();
        
        }

        public void checking()
        {
            if (radioButton1.Checked) radioButton2.Checked = false;
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
           
            switch (classname)
            {
                case "c1q1":
                    label2.Text = "1. Για την πρόσθεση n αριθμών χρειάζεται να χρησιμοποιήσουμε:";
                    label3.Text = "2. Για τις εντολές add και subtract έχουμε πάντα 2 τελεστές";
                    label4.Text = "3. Η προσπέλαση των καταχωρητών είναι γρηγορότερηη από την προσπέλαση της μνήμης.";
                    label5.Text = "4. Ο μεταγλωττιστής πρέπει να χρησιμοποιεί όσο " + Environment.NewLine +
                        "το δυνατό λιγότερο τους καταχωρητές για τις μεταβλητές.";
                    label6.Text = "5. Οι μη αρνητικοί αριθμοί έχουν την ίδια απρόσημη " +
                        "αναπαράσταση και σε συμπλήρωμα ως προς 2.";
                    radioButton1.Text = "n/2+1 εντολές";
                    radioButton2.Text = "n εντολές";
                    radioButton3.Text = "Σωστό";
                    radioButton4.Text = "Λάθος";
                    radioButton5.Text = "Σωστό";
                    radioButton6.Text = "Λάθος";
                    radioButton7.Text = "Σωστό";
                    radioButton8.Text = "Λάθος";
                    radioButton9.Text = "Σωστό";
                    radioButton10.Text = "Λάθος";
                    break;

                case "c1q2":
                    label2.Text = "1. Στην υπερχείλιση, η πράξη Α+Β με Α>=0 και Β>=0 έχει ως αποτέλεσμα:";
                    label3.Text = "2. Στην υπερχείλιση, η πράξη Α-Β με Α>=0 και Β<0 έχει ως αποτέλεσμα:";
                    label4.Text = "3. Ο MIPS παρέχει ένα τρόπο για την αγνόηση της υπερχείλισης" +
                        " σε μερικές περιπτώσεις και την αναγνώρισή της σε άλλες.";
                    label5.Text = "4. Κάποιοι μεταγλωττιστές αντικαθιστούν τις πράξεις πολ/μου" + Environment.NewLine +
                        " με σταθερές με μια σειρά από ολισθήσεις και προσθέσεις.";
                    label6.Text = "5.Ο MIPS παρέχει ένα τρόπο για την αγνόηση της υπερχείλισης σε µερικές περιπτώσεις και την αναγνώρισή της σε άλλες";
                    radioButton1.Text = "<0";
                    radioButton2.Text = ">=0";
                    radioButton3.Text = ">=0";
                    radioButton4.Text = "<0";
                    radioButton5.Text = "Σωστό";
                    radioButton6.Text = "Λάθος";
                    radioButton7.Text = "Σωστό";
                    radioButton8.Text = "Λάθος";
                    radioButton9.Text = "Σωστό";
                    radioButton10.Text = "Λάθος";
                    break;
                case "c1q3":
                    label2.Text = "1. Για την πρόσθεση n αριθμών χρειάζεται να χρησιμοποιήσουμε:";
                    label3.Text = "2. Η προσπέλαση των καταχωρητών είναι γρηγορότερηη από την προσπέλαση της μνήμης.";
                    label4.Text = "3. Στην υπερχείλιση, η πράξη Α+Β με Α>=0 και Β>=0 έχει ως αποτέλεσμα:";
                    label5.Text = "4. Οι μη αρνητικοί αριθμοί έχουν την ίδια απρόσημη αναπαράσταση " +
                        "και σε συμπλήρωμα ως προς 2.";
                    label6.Text = "5. Ο MIPS παρέχει ένα τρόπο για την αγνόηση της υπερχείλισης " +
                        "σε μερικές περιπτώσεις και την αναγνώρισή της σε άλλες.";
                    radioButton1.Text = "n/2+1 εντολές";
                    radioButton2.Text = "n εντολές";
                    radioButton3.Text = "Σωστό";
                    radioButton4.Text = "Λάθος";
                    radioButton5.Text = "<0";
                    radioButton6.Text = ">=0";
                    radioButton7.Text = "Σωστό";
                    radioButton8.Text = "Λάθος";
                    radioButton9.Text = "Σωστό";
                    radioButton10.Text = "Λάθος";
                    break;

                case "c2q1":
                    label2.Text= "1.Όταν οι αριθμοί είναι μόνο θετικοί και " +
                        "0 τότε μπορούν να παρασταθούν οι αριθμοί από 0(0....000) μέχρι 2n - 1(1....111).";
                    label3.Text = "2. Το άθροισμα της πρόσθεσης 0111(2)+0110(2) ισούται με:";
                    label4.Text = "3. Το συμπλήρωμα ως προς βάση ενός αριθμού Ν είναι ίσο με το συμπλήρωμα ως προς ελαττωμένη βάση - 1.";
                    label5.Text = "4.Το συμπλήρωμα ως προς 2 μπορεί να παραχθεί από το συμπλήρωμα ως προς 1 προσθέτοντας 1.";
                    label6.Text = "5. Στους προσημασμένους αριθμούς σε συμπλήρωμα η εμφάνιση κρατουμένου σχετίζεται με την υπερχείλιση.";
                    radioButton1.Text = "Σωστό";
                    radioButton2.Text = "Λάθος";
                    radioButton3.Text = "13(10)";
                    radioButton4.Text = "7(10)";
                    radioButton5.Text = "Σωστό";
                    radioButton6.Text = "Λάθος";
                    radioButton7.Text = "Σωστό";
                    radioButton8.Text = "Λάθος";
                    radioButton9.Text = "Σωστό";
                    radioButton10.Text = "Λάθος";
                    break;
                case "c2q2":
                    label2.Text = "1. Το λογικό ΚΑΙ (AND) ή σύζευξη:";
                    label3.Text = "2. Συχνά το λογικό AND ονομάζεται «πολλαπλασιασμός»και το λογικό ORονομάζεται «πρόσθεση».";
                    label4.Text = "3.Η πράξη + είναι προσεταιριστική δηλαδή (x + y) + z = x + (y + z)";
                    label5.Text = "3. Η F2 μπορεί να απλοποιηθεί F2= x’ y’ z + x’ y z + x y’= x’ z (y’ + y) + x y’:";
                    label6.Text = "4. Το συμπλήρωμα της F1= x’yz’+x’y’z είναι:";
                    radioButton1.Text = "Δίνει αποτέλεσμα 1 μόνο όταν και το x και το yείναι ίσα με 1. " + Environment.NewLine +
                        "Διαφορετικά το αποτέλεσμα του λογικού ΚΑΙ είναι ίσο με 0.";
                    radioButton2.Text = "Όταν το x είναι ίσο με 1 τότε το x’ είναι ίσο με 0 και αντίστροφα";
                    radioButton3.Text = "Σωστό";
                    radioButton4.Text = "Λάθος";
                    radioButton5.Text = "Σωστό";
                    radioButton6.Text = "Λάθος";
                    radioButton7.Text = "x'z+ x'y'";
                    radioButton8.Text = "x'z+ xy'";
                    radioButton9.Text = "(x+y'+z')(x'+y+z)";
                    radioButton10.Text = "(x+y’+z)(x+y+z’)";
                    break;
                case "c2q3":
                    label2.Text = "1.Το άθροισμα της πρόσθεσης 0111(2)+0110(2) ισούται με:";
                    label3.Text = "2.Το συμπλήρωμα ως προς 2 μπορεί να παραχθεί από το συμπλήρωμα ως προς 1 προσθέτοντας 1.";
                    label4.Text = "3.Το συμπλήρωμα της F1= x’yz’+x’y’z είναι:";
                    label5.Text = "4.Όταν οι αριθμοί είναι μόνο θετικοί και 0 τότε μπορούν να παρασταθούν οι αριθμοί από 0(0....000) μέχρι 2n - 1(1....111).";
                    label6.Text = "5.Το λογικό ΚΑΙ (AND) ή σύζευξη:";
                    radioButton1.Text = "13(10)";
                    radioButton2.Text = "7(10)";
                    radioButton3.Text = "Σωστό";
                    radioButton4.Text = "Λάθος";
                    radioButton5.Text = "(x+y'+z')(x'+y+z)";
                    radioButton6.Text = "(x+y’+z)(x+y+z’)";
                    radioButton7.Text = "Σωστό";
                    radioButton8.Text = "Λάθος";
                    radioButton9.Text = "Δίνει αποτέλεσμα 1 όταν τουλάχιστον ένα από τα x,y =1.";
                    radioButton10.Text = "Δίνει αποτέλεσμα 1 μόνο όταν x και y είναι ίσα με 1. ";        
                    break;
                case "c3q1":
                    label2.Text = "1.Oι τιμές που εισάγονται στη ΒΔ πρέπει να είναι συμβατές με τα πεδία τιμών που έχουν δηλωθεί.";
                    label3.Text = "2. Τα δεδομένα αναπαριστούν ένα υποσύνολο των στοιχείων που" + Environment.NewLine +
                        " μπορούμε να συλλέξουμε για τον μικρόκοσμο (πεδίο αναφοράς) μιας εφαρμογής.";
                    label4.Text = "3. Τα δεδομένα είναι γνωστά γεγονότα-περιστατικά που καταγράφονται και έχουν νόημα.";
                    label5.Text = "4.Η ΒΔ αποτελείται από ένα σύνολο σχέσεων (relations)" + Environment.NewLine +
                        " ή πινάκων (tables) που συνδέονται κατάλληλα μεταξύ τους.";
                    label6.Text = "5.Ένα σύνολο πλειάδων (εγγραφών, γραμμών) ορισμένων " + Environment.NewLine +
                        "βάσει κάποιων χαρακτηριστικών (πεδίων, στηλών).";
                    radioButton1.Text = "Περιορισμός αναφορικής ακεραιότητας.";
                    radioButton2.Text = "Περιορισμός πεδίου τιμών.";
                    radioButton3.Text = "Σωστό";
                    radioButton4.Text = "Λάθος";
                    radioButton5.Text = "Σωστό";
                    radioButton6.Text = "Λάθος";
                    radioButton7.Text = "Σωστό";
                    radioButton8.Text = "Λάθος";
                    radioButton9.Text = "Σωστό";
                    radioButton10.Text = "Λάθος";
                    break;
                case "c3q2":
                    label2.Text = "Έστω K Í R ένα σύνολο χαρακτηριστικών ενός σχεσιακού σχήματος 1." + Environment.NewLine +
                        "Το K είναι υποψήφιο κλειδί του R εάν οι τιμές του K " +
                        "αρκούν για να ταυτοποιήσουν μια πλειάδα της όποιας σχέσης r(R).";
                    label3.Text = "2. Το Κ είναι υπερ-κλειδί εάν είναι ελάχιστο.";
                    label4.Text = "3.Το πρωτεύον κλειδί του R είναι ένα από τα υποψήφια κλειδιά του" + Environment.NewLine +
                        " και το ποιο θα είναι αυτό αποφασίζεται από τον σχεδιαστή της ΒΔ.";
                    label5.Text = "4.Το πρωτεύον κλειδί (primary key) PK μιας σχέσης R δεν μπορεί να έχει κενές (null) " + Environment.NewLine +
                        "ή επαναλαμβανόμενες τιμές στις πλειάδες t ενός στιγμιοτύπου r(R) της σχέσης R.";
                    label6.Text = "5.Αν μία πλειάδα tR πρόκειται να διαγραφεί από την R," +
                        " υπολογίζεται το σύνολο των πλειάδων tS της S που αναφέρονται στην πλειάδα tR." + Environment.NewLine +
                        "Αν το σύνολο είναι κενό, κανένα πρόβλημα.";
                    radioButton1.Text = "Σωστό";
                    radioButton2.Text = "Λάθος";
                    radioButton3.Text = "Σωστό";
                    radioButton4.Text = "Λάθος";
                    radioButton5.Text = "Σωστό";
                    radioButton6.Text = "Λάθος";
                    radioButton7.Text = "Σωστό";
                    radioButton8.Text = "Λάθος";
                    radioButton9.Text = "Σωστό";
                    radioButton10.Text = "Λάθος";
                    break;
                case "c3q3":
                    label2.Text = "1.Τα δεδομένα είναι γνωστά γεγονότα-περιστατικά που καταγράφονται και έχουν νόημα.";
                    label3.Text = "2.Oι τιμές που εισάγονται στη ΒΔ πρέπει να είναι συμβατές με τα πεδία τιμών που έχουν δηλωθεί.";
                    label4.Text = "3.Το πρωτεύον κλειδί (primary key) PK μιας σχέσης R δεν μπορεί να έχει κενές (null) " + Environment.NewLine +
                        "ή επαναλαμβανόμενες τιμές στις πλειάδες t ενός στιγμιοτύπου r(R) της σχέσης R.";
                    label5.Text = "4.Αν μία πλειάδα tR πρόκειται να διαγραφεί από την R," + Environment.NewLine +
                        " υπολογίζεται το σύνολο των πλειάδων tS της S που αναφέρονται στην πλειάδα tR." + Environment.NewLine +
                        "Αν το σύνολο είναι κενό, κανένα πρόβλημα.";
                    label6.Text = "5.Η ΒΔ αποτελείται από ένα σύνολο σχέσεων (relations)" + Environment.NewLine +
                        " ή πινάκων (tables) που συνδέονται κατάλληλα μεταξύ τους.";
                    radioButton1.Text = "Σωστό";
                    radioButton2.Text = "Λάθος";
                    radioButton3.Text = "Περιορισμός αναφορικής ακεραιότητας.";
                    radioButton4.Text = "Περιορισμός πεδίου τιμών.";
                    radioButton5.Text = "Σωστό";
                    radioButton6.Text = "Λάθος";
                    radioButton7.Text = "Σωστό";
                    radioButton8.Text = "Λάθος";
                    radioButton9.Text = "Σωστό";
                    radioButton10.Text = "Λάθος";
                    break;
                case "c4q1":
                    label2.Text = "1. Το κόστος της σειριακής αναζήτησς σε πίνακα είναι:";
                    label3.Text = "2. H εισαγωγή και διαγραφή k-οστού στοιχείου είναι Θ(n)" + Environment.NewLine +
                        " τόσο στις στατικές όσο και στις συνδεδεμένες αλυσίδες";
                    label4.Text = "3. Η εύρεση τιμής k-οστού στοιχείου είναι Θ(n) στις στατικές λίστες";
                    label5.Text = "4. Η αναζήτηση στοιχείου με τιμή x είναι Θ(n) στις συνδεδεμένες λίστες";
                    label6.Text = "5. Στις στατικές λίστες ο χώρος πρέπει να δεσμευτεί εκ των προτέρων";
                    radioButton1.Text = "Ο(n)";
                    radioButton2.Text = "Ο(logn)";
                    radioButton3.Text = "Σωστό";
                    radioButton4.Text = "Λάθος";
                    radioButton5.Text = "Σωστό";
                    radioButton6.Text = "Λάθος";
                    radioButton7.Text = "Σωστό";
                    radioButton8.Text = "Λάθος";
                    radioButton9.Text = "Σωστό";
                    radioButton10.Text = "Λάθος";
                    break;
                case "c4q2":
                    label2.Text = "1. Ποιος από τους παρακάτω κώδικες αφορά την προσθήκη στην στοίβα;";
                    label3.Text = "2. Η δομή της ουράς ειναι τύπου LIFO (Last in- First Out):";
                    label4.Text = "3. Η δομή της στοίβας ειναι τύπου LIFO (Last in- First Out):";
                    label5.Text = "4. Περιορισμένος τύπος γραμμικής λίστας: " +
                        "Εισαγωγή στο ένα άκρο (στο τέλος) και διαγραφή από το άλλο (την αρχή). ";
                    label6.Text = "5. Η FIFO λειτουργεί ως Περιορισµένος τύπος γραµµικής λίστας:"+Environment.NewLine+ 
                        "Εισαγωγή στο ένα άκρο(στο τέλος) και διαγραφή από το άλλο(την αρχή)";
                    radioButton1.Text = "Stack<T>& Stack<T>::Delete(T& x){if (IsEmpty())";
                    radioButton2.Text = "Stack<T>& Stack<T>::Add(const T& x){if (IsFull())";                  
                    radioButton3.Text = "Σωστό";
                    radioButton4.Text = "Λάθος";
                    radioButton5.Text = "Σωστό";
                    radioButton6.Text = "Λάθος";
                    radioButton7.Text = "Στοίβα";
                    radioButton8.Text = "Ουρά";
                    radioButton9.Text = "Σωστό";
                    radioButton10.Text= "Λάθος";
                    break;
                case "c4q3":
                    label2.Text = "1.Ποιος από τους παρακάτω κώδικες αφορά την προσθήκη στην στοίβα;";
                    label3.Text = "2.Το κόστος της σειριακής αναζήτησς σε πίνακα είναι:";
                    label4.Text = "3. Η αναζήτηση στοιχείου με τιμή x είναι Θ(n) στις συνδεδεμένες λίστες";
                    label5.Text = "4.Η εύρεση τιμής k-οστού στοιχείου είναι Θ(n) στις στατικές λίστες";
                    label6.Text = "5.H εισαγωγή και διαγραφή k-οστού στοιχείου είναι Θ(n)" + Environment.NewLine +
                        " τόσο στις στατικές όσο και στις συνδεδεμένες αλυσίδες";
                    radioButton1.Text = "Stack<T>& Stack<T>::Delete(T& x)";
                    radioButton2.Text = "Stack<T>& Stack<T>::Add(const T& x)";               
                    radioButton3.Text = "Ο(n)";
                    radioButton4.Text = "Ο(logn)";
                    radioButton5.Text = "Σωστό";
                    radioButton6.Text = "Λάθος";
                    radioButton7.Text = "Σωστό";
                    radioButton8.Text = "Λάθος";
                    radioButton9.Text = "Σωστό";
                    radioButton10.Text = "Λάθος";
                    break;
                case "c5q1":
                    label2.Text = "1. Σε πόσες μεγάλες κατηγορίες χωρίζονταιοι τελεστές της C++?";
                    label3.Text = "2. Ποια πράξη θα εκτελεστεί πρώτη στο ακόλουθο; a = x-(k+1)*5";
                    label4.Text = "3. Το < είναι:";
                    label5.Text = "4. Το & είναι:";
                    label6.Text = "5. Το ++ είναι:";
                    radioButton1.Text = "Πέντε";
                    radioButton2.Text = "Δύο";
                    radioButton3.Text = "k+1";
                    radioButton4.Text = "(k+1)*7";
                    radioButton5.Text = "Τελεστής κίνησης";
                    radioButton6.Text = "Σχεσιακός τελεστής";
                    radioButton7.Text = "Ψηφιακός Τελεστής";
                    radioButton8.Text = "Προσθετικός Τελεστής";
                    radioButton9.Text = "Υπό συνθήκη τελεστής";
                    radioButton10.Text = "Τελεστής Αντικατάστασης";
                    break;
                case "c5q2":
                    label2.Text = "1. Η συνάρτηση isalnum επιστρέφει True αν ο χαρακτήρας δεν είναι ούτε γράμμα," + Environment.NewLine +
                        " ούτε ψηφίο (αλφαριθμητικός) δηλαδή από ‘A’–‘Z’ ή ‘a’–‘z’ ή ‘0’–‘9’.";
                    label3.Text = "2. Η συνάρτηση isalpha επιστρέφει 0 αν ο χαρακτήρας είναι κεφαλαίο λατινικό γράμμα.";
                    label4.Text = "3. Η συνάρτηση acos επιστρέφει:";
                    label5.Text = "4. Η συνάρτηση getcwd χρησιμοποιείται για την δημιουργία νέου καταλόγου.";
                    label6.Text = "5. Η συνάρτηση pow επιστρέφει την τιμή xy:";
                    radioButton1.Text = "Σωστό";
                    radioButton2.Text = "Λάθος";
                    radioButton3.Text = "Σωστό";
                    radioButton4.Text = "Λάθος";
                    radioButton5.Text = "Το τόξο συνημιτόνου ενός πραγματικού τύπου double.";
                    radioButton6.Text = "Το τόξο ημιτόνου ενός πραγματικού τύπου double.";
                    radioButton7.Text = "Σωστό";
                    radioButton8.Text = "Λάθος";
                    radioButton9.Text = "Σωστό";
                    radioButton10.Text = "Λάθος";
                    break;
                case "c5q3":
                    label2.Text = "1. Ποια πράξη θα εκτελεστεί πρώτη στο ακόλουθο; a = x-(k+1)*5";
                    label3.Text = "2.Η συνάρτηση acos επιστρέφει:";
                    label4.Text = "3. Η συνάρτηση pow επιστρέφει την τιμή xy:";
                    label5.Text = "4.Το ++ είναι:";
                    label6.Text = "5.Η συνάρτηση isalnum επιστρέφει True αν ο χαρακτήρας δεν είναι ούτε γράμμα," + Environment.NewLine +
                        " ούτε ψηφίο (αλφαριθμητικός) δηλαδή από ‘A’–‘Z’ ή ‘a’–‘z’ ή ‘0’–‘9’.";
                    radioButton1.Text = "k+1";
                    radioButton2.Text = "(k+1)*7";
                    radioButton3.Text = "Το τόξο συνημιτόνου ενός πραγματικού τύπου double.";
                    radioButton4.Text = "Το τόξο ημιτόνου ενός πραγματικού τύπου double.";
                    radioButton5.Text = "Σωστό";
                    radioButton6.Text = "Λάθος";
                    radioButton7.Text = "Υπό συνθήκη τελεστής";
                    radioButton8.Text = "Τελεστής Αντικατάστασης";
                    radioButton9.Text = "Σωστό";
                    radioButton10.Text = "Λάθος";
                    break;
                case "c6q1":
                    label2.Text = "1.Εκτός από τα imports τάξεων και interfaces υπάρχει και" +
                        " η δυνατότητα να κάνουμε import σε μεταβλητές (χαρακτηριστικά) ή/και σε μεθόδους τάξεων.";
                    label3.Text = "2. Οι access modifiers στην java είναι:";
                    label4.Text = "3. Η final δεν είναι non-access modifier.";
                    label5.Text = "4. Η native αφορά μόνο:";
                    label6.Text = "5. Η transient υποδηλώνει ότι οι υπολογισμοί που θα γίνουν και" + Environment.NewLine +
                        " αφορούν αριθμούς κινητής υποδιαστολής," + Environment.NewLine +
                        " θα είναι ίδιοι σε όλες τις πλατφόρμες.";
                    radioButton1.Text = "Σωστό";
                    radioButton2.Text = "Λάθος";
                    radioButton3.Text = "7";
                    radioButton4.Text = "4";
                    radioButton5.Text = "Σωστό";
                    radioButton6.Text = "Λάθος";
                    radioButton7.Text = "Μεθόδους";
                    radioButton8.Text = "interfaces";
                    radioButton9.Text = "Σωστό";
                    radioButton10.Text = "Λάθος";
                    break;
                case "c6q2":
                    label2.Text = "1. Η abstract εφαρμόζεται σε μόνο σε μεθόδους.";
                    label3.Text = "2. Οι μεταβλητές τύπου static μπορούν να δηλωθούν σε μια class αλλά να ανήκουν σε πολλές.";
                    label4.Text = "3.Μια final class δεν μπορεί να την επεκτείνει (μέσω κληρονομικότητας) καμία τάξη.";
                    label5.Text = "4.Μη στατικές μέθοδοι και μεταβλητές μπορούν να προσπελάσουν στατικές μεθόδους και μεταβλητές.";
                    label6.Text = "5. Τα εμφωλευμένα interfaces πρέπει πάντα να τα δηλώνουμε ως static γιατί διαφορετικά δηλώνονται σαν default.";
                    radioButton1.Text = "Σωστό";
                    radioButton2.Text = "Λάθος";
                    radioButton3.Text = "Σωστό";
                    radioButton4.Text = "Λάθος";
                    radioButton5.Text = "Σωστό";
                    radioButton6.Text = "Λάθος";
                    radioButton7.Text = "Σωστό";
                    radioButton8.Text = "Λάθος";
                    radioButton9.Text = "Σωστό";
                    radioButton10.Text = "Λάθος";
                    break;
                case "c6q3":
                    label2.Text = "1.Εκτός από τα imports τάξεων και interfaces υπάρχει και" + Environment.NewLine +
                        " η δυνατότητα να κάνουμε import σε μεταβλητές (χαρακτηριστικά) ή/και σε μεθόδους τάξεων.";
                    label3.Text = "2.Μια final class δεν μπορεί να την επεκτείνει (μέσω κληρονομικότητας) καμία τάξη.";
                    label4.Text = "3.Η native αφορά μόνο:";
                    label5.Text = "4.Τα εμφωλευμένα interfaces πρέπει πάντα να τα δηλώνουμε ως static γιατί διαφορετικά δηλώνονται σαν default.";
                    label6.Text = "5.Μη στατικές μέθοδοι και μεταβλητές μπορούν να προσπελάσουν στατικές μεθόδους και μεταβλητές.";
                    radioButton1.Text = "Σωστό";
                    radioButton2.Text = "Λάθος";
                    radioButton3.Text = "Σωστό";
                    radioButton4.Text = "Λάθος";
                    radioButton5.Text = "Μεθόδους";
                    radioButton6.Text = "interfaces";
                    radioButton7.Text = "Σωστό";
                    radioButton8.Text = "Λάθος";
                    radioButton9.Text = "Σωστό";
                    radioButton10.Text = "Λάθος";
                    break;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "appdb";
            MySqlConnection connection = new MySqlConnection(builder.ToString());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            switch (classname)
            {
                case "c1q1":
                    score = 0;
                    if (radioButton1.Checked) { score = score + 2; }
                    if (radioButton4.Checked) { score = score + 2; }
                    if (radioButton5.Checked) { score = score + 2; }
                    if (radioButton8.Checked) { score = score + 2; }
                    if (radioButton9.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c1q2":
                    score = 0;
                    if (radioButton1.Checked) { score = score + 2; }
                    if (radioButton4.Checked) { score = score + 2; }
                    if (radioButton5.Checked) { score = score + 2; }
                    if (radioButton7.Checked) { score = score + 2; }
                    if (radioButton9.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c1q3":
                    score = 0;
                    if (radioButton1.Checked) { score = score + 2; }
                    if (radioButton3.Checked) { score = score + 2; }
                    if (radioButton5.Checked) { score = score + 2; }
                    if (radioButton7.Checked) { score = score + 2; }
                    if (radioButton9.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c2q1":
                    score = 0;
                    if (radioButton1.Checked) { score = score + 2; }
                    if (radioButton3.Checked) { score = score + 2; }
                    if (radioButton6.Checked) { score = score + 2; }
                    if (radioButton7.Checked) { score = score + 2; }
                    if (radioButton10.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c2q2":
                    score = 0;
                    if (radioButton1.Checked) { score = score + 2; }
                    if (radioButton3.Checked) { score = score + 2; }
                    if (radioButton5.Checked) { score = score + 2; }
                    if (radioButton8.Checked) { score = score + 2; }
                    if (radioButton9.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c2q3":
                    score = 0;
                    if (radioButton1.Checked) { score = score + 2; }
                    if (radioButton3.Checked) { score = score + 2; }
                    if (radioButton6.Checked) { score = score + 2; }
                    if (radioButton7.Checked) { score = score + 2; }
                    if (radioButton10.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c3q1":
                    score = 0;
                    if (radioButton2.Checked) { score = score + 2; }
                    if (radioButton4.Checked) { score = score + 2; }
                    if (radioButton5.Checked) { score = score + 2; }
                    if (radioButton7.Checked) { score = score + 2; }
                    if (radioButton9.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c3q2":
                    score = 0;
                    if (radioButton2.Checked) { score = score + 2; }
                    if (radioButton4.Checked) { score = score + 2; }
                    if (radioButton5.Checked) { score = score + 2; }
                    if (radioButton7.Checked) { score = score + 2; }
                    if (radioButton9.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c3q3":
                    score = 0;
                    if (radioButton1.Checked) { score = score + 2; }
                    if (radioButton4.Checked) { score = score + 2; }
                    if (radioButton5.Checked) { score = score + 2; }
                    if (radioButton7.Checked) { score = score + 2; }
                    if (radioButton9.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c4q1":
                    score = 0;
                    if (radioButton1.Checked) { score = score + 2; }
                    if (radioButton3.Checked) { score = score + 2; }
                    if (radioButton6.Checked) { score = score + 2; }
                    if (radioButton7.Checked) { score = score + 2; }
                    if (radioButton9.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c4q2":
                    score = 0;
                    if (radioButton2.Checked) { score = score + 2; }
                    if (radioButton4.Checked) { score = score + 2; }
                    if (radioButton5.Checked) { score = score + 2; }
                    if (radioButton7.Checked) { score = score + 2; }
                    if (radioButton9.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c4q3":
                    score = 0;
                    if (radioButton2.Checked) { score = score + 2; }
                    if (radioButton3.Checked) { score = score + 2; }
                    if (radioButton5.Checked) { score = score + 2; }
                    if (radioButton8.Checked) { score = score + 2; }
                    if (radioButton9.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c5q1":
                    score = 0;
                    if (radioButton2.Checked) { score = score + 2; }
                    if (radioButton4.Checked) { score = score + 2; }
                    if (radioButton6.Checked) { score = score + 2; }
                    if (radioButton7.Checked) { score = score + 2; }
                    if (radioButton10.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c5q2":
                    score = 0;
                    if (radioButton2.Checked) { score = score + 2; }
                    if (radioButton3.Checked) { score = score + 2; }
                    if (radioButton5.Checked) { score = score + 2; }
                    if (radioButton8.Checked) { score = score + 2; }
                    if (radioButton9.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c5q3":
                    score = 0;
                    if (radioButton2.Checked) { score = score + 2; }
                    if (radioButton3.Checked) { score = score + 2; }
                    if (radioButton5.Checked) { score = score + 2; }
                    if (radioButton8.Checked) { score = score + 2; }
                    if (radioButton10.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c6q1":
                    score = 0;
                    if (radioButton1.Checked) { score = score + 2; }
                    if (radioButton4.Checked) { score = score + 2; }
                    if (radioButton6.Checked) { score = score + 2; }
                    if (radioButton7.Checked) { score = score + 2; }
                    if (radioButton10.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c6q2":
                    score = 0;
                    if (radioButton2.Checked) { score = score + 2; }
                    if (radioButton4.Checked) { score = score + 2; }
                    if (radioButton5.Checked) { score = score + 2; }
                    if (radioButton7.Checked) { score = score + 2; }
                    if (radioButton10.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
                case "c6q3":
                    score = 0;
                    if (radioButton1.Checked) { score = score + 2; }
                    if (radioButton3.Checked) { score = score + 2; }
                    if (radioButton5.Checked) { score = score + 2; }
                    if (radioButton8.Checked) { score = score + 2; }
                    if (radioButton9.Checked) { score = score + 2; }
                    connection.Open();
                    cmd.CommandText = "UPDATE progress SET progress" + classname + "= @pscore WHERE username= @uname";
                    cmd.Parameters.AddWithValue("@pscore", score);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    break;
            }
            MessageBox.Show("Your answers have been submitted!Successfully");
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
       
        
           

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form previousForm = Form.ActiveForm;
            previousForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            QuizHelper quizHelper = new QuizHelper();
            quizHelper.Show();
        }
    }
}
