package ece.np.edu.s10195575mp2_p2a5;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import java.util.List;

public class MainActivity extends AppCompatActivity {

    Button btLogin, btSignUp;
    EditText etPassword, etName;
    String Username;
    String Password;
    UserClass user;
    DataBaseUser userDb;
    
    private static final int REQUEST_CODE = 99;

    private View.OnClickListener loginListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {

            if (etName.getText().toString().equals(Username) &&
                    etPassword.getText().toString().equals(Password)) {
                Intent Budget = new Intent(getBaseContext(), MenuActivity.class);
                startActivity(Budget);
            }

            if (etName.getText().toString().equals("")) {
                Toast.makeText(getBaseContext(),
                        "Please enter Username", Toast.LENGTH_SHORT).show();
                etName.findFocus();
            }
            else if (etPassword.getText().toString().equals("")) {
                Toast.makeText(getBaseContext(),
                        "Please enter Password", Toast.LENGTH_SHORT).show();
                etPassword.findFocus();
            }
            else {
                userDb = new DataBaseUser(getBaseContext());
                List<UserClass> allItems = userDb.getUser();
                
                for (int i = 0; i < allItems.size(); i++) {
                    Username = allItems.get(i).getStrName();
                    Password = allItems.get(i).getStrPassword();

                    if (etName.getText().toString().equals(Username) &&
                            etPassword.getText().toString().equals(Password)) {
                        Intent Budget = new Intent(getBaseContext(), MenuActivity.class);
                        startActivity(Budget);
                    }
                    else {
                        Toast.makeText(getBaseContext(), "Wrong Username or Password", Toast.LENGTH_SHORT).show();
                    }
                }
            }
        }
    };

    private View.OnClickListener signUpListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            Intent SignUp = new Intent(getBaseContext(), SignUpActivity.class);
            startActivityForResult(SignUp, REQUEST_CODE);
        }
    };

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if (requestCode == REQUEST_CODE) {
            if (resultCode == RESULT_OK) {
                Username = data.getStringExtra("string_username");
                Password = data.getStringExtra("string_password");
                user = new UserClass(Username, Password);
                DataBaseUser userDb = new DataBaseUser(getBaseContext());
                userDb.InsertUserData(user);
                Toast.makeText(getBaseContext(),
                        "User was created", Toast.LENGTH_SHORT).show();
            }
            else if (resultCode == RESULT_CANCELED) {
                Toast.makeText(getBaseContext(),
                        "No user was created", Toast.LENGTH_SHORT).show();
            }
        }
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        etName = this.findViewById(R.id.etName);
        etPassword = this.findViewById(R.id.etPassword);
        btLogin = this.findViewById(R.id.btLogin);
        btSignUp = this.findViewById(R.id.btSignUp);

        btLogin.setOnClickListener(loginListener);
        btSignUp.setOnClickListener(signUpListener);

    }
}