package ece.np.edu.s10195575mp2_p2a5;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class SignUpActivity extends AppCompatActivity {

    EditText etNewName, etNewPassword;
    Button btCreate, btCancel;
    UserClass user;

    private View.OnClickListener createListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            if (etNewName.getText().toString().isEmpty()) {
                //Tell user to enter username if empty
                Toast.makeText(getBaseContext(),
                        "Please enter username!", Toast.LENGTH_SHORT).show();
                etNewName.findFocus();
            }
            else if (etNewPassword.getText().toString().isEmpty()) {
                //Tell user to enter password if empty
                Toast.makeText(getBaseContext(),
                        "Please enter password!", Toast.LENGTH_SHORT).show();
                etNewPassword.findFocus();
            }
            else {
                //Put username and password into a variable to pass to login activity
                String Username = etNewName.getText().toString();
                String Password = etNewPassword.getText().toString();
                //Go back to login activity
                Intent Login = new Intent(getBaseContext(), MainActivity.class);
                Login.putExtra("string_username", Username);
                Login.putExtra("string_password", Password);
                setResult(RESULT_OK, Login);
                finish();
            }

        }
    };

    private View.OnClickListener cancelListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            //Does not want to create, go back to login activity
            Intent Login = new Intent(getBaseContext(), MainActivity.class);
            setResult(RESULT_CANCELED, Login);
            finish();
        }
    };

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_sign_up);

        etNewName = this.findViewById(R.id.etNewName);
        etNewPassword = this.findViewById(R.id.etNewPassword);
        btCreate = this.findViewById(R.id.btCreate);
        btCancel = this.findViewById(R.id.btCancel);

        btCreate.setOnClickListener(createListener);
        btCancel.setOnClickListener(cancelListener);
    }
}