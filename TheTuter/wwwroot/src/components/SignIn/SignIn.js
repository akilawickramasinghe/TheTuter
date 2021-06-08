import React, { useState } from "react";
import Button from '@material-ui/core/Button';
import Dialog from '@material-ui/core/Dialog';
import IconButton from '@material-ui/core/IconButton';
import CloseIcon from '@material-ui/icons/Close';
import CssBaseline from '@material-ui/core/CssBaseline';
import TextField from '@material-ui/core/TextField';
import Grid from '@material-ui/core/Grid';
import Typography from '@material-ui/core/Typography';
import { makeStyles } from '@material-ui/core/styles';
import Container from '@material-ui/core/Container';
import Checkbox from '@material-ui/core/Checkbox';
import FormControlLabel from '@material-ui/core/FormControlLabel';
// import { Link } from 'react-router-dom';
import axios from 'axios';
import  { useHistory , Redirect ,Link} from 'react-router-dom';

function Copyright() {
  return (
    <Typography variant="body2" color="textSecondary" align="center">
      {'Copyright © '}
      <Link style={{color:"red"}} to="/home">
        ONILINE EDUCATION
      </Link>{' '}
      {new Date().getFullYear()}
      {'.'}
    </Typography>
  );
}

const useStyles = makeStyles((theme) => ({
  paper: {
    marginTop: theme.spacing(2),
    marginBottom: theme.spacing(2),
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
  },
 
  form: {
    width: '100%', 
    marginTop: theme.spacing(3),
    
  },
  submit: {
    margin: theme.spacing(3, 0, 2),
  },
  root: {
    margin: 0,
    padding: theme.spacing(2),
  },
  closeButton: {
    position: 'absolute',
    right: theme.spacing(1),
    top: theme.spacing(1),
    color: theme.palette.grey[500],
  },

}));



export default function SignIn() {

  const classes = useStyles();
  const history = useHistory();

  const [open, setOpen] = React.useState(false);

  const handleClickOpen = () => {
    setOpen(true);
  };
  const handleClose = () => {
    setOpen(false);
  };

  const [email, setEmail] =  useState("");
  const [password, setPassword] =  useState("");
  const [errorMessage, setErrorMessage] =  useState("");

  const onSubmit = (async(e) => {
    e.preventDefault();
    const postData = {
      email,
      password
    };
      await axios.post('/api/Accounts/login', postData)
    .then((res) => {
      debugger
      if(res.data.role == "Teacher"){
        // <a style={{ color: "black", textDecoration: "none" }} to="./accSTmenu" />
        // return <Redirect to='/accSTmenu'  />
        localStorage.setItem('UserId', res.data.id);
        localStorage.setItem('FirstName', res.data.firstName);
        localStorage.setItem('LastName', res.data.lastName);
        history.push("/AccTCRaddnew");
      }else if(res.data.role == "Student"){
        localStorage.setItem('UserIdStd', res.data.id);
        localStorage.setItem('FirstName', res.data.firstName);
        localStorage.setItem('LastName', res.data.lastName);
        history.push("/accSTmenu");
      }else if(res.data == "EmailPasswordIncorrect"){
        setErrorMessage("Email or Password is incorrect!");
      }
    }).catch((err) =>{
      setErrorMessage(err.message);
    });
  });

  return (
    <div>
      <Button type="submit" variant="contained" color="primary" onClick={handleClickOpen}>
        Login
      </Button>
      <Dialog open={open}>
        <div onClick={handleClose}>
        <IconButton  className={classes.closeButton} >
          <CloseIcon />
        </IconButton>
        </div>

         <div>              
                                            
         <Container component="main" maxWidth="xs">
      <CssBaseline />
      <div className={classes.paper}>
        
        <Typography component="h1" variant="h5" color='primary'>
          Sign in
        </Typography>
        {errorMessage && <span style={{ color: "red", fontSize: "20px" }}>{errorMessage}</span>}
        <form onSubmit={onSubmit} className={classes.form} noValidate>
        <TextField
               onChange={(e) =>{setEmail(e.target.value)}}
                variant="outlined"
                required
                fullWidth
                id="email"
                label="Email Address"
                name="email"
                autoComplete="email"
              />
            <TextField
               onChange={(e) =>{setPassword(e.target.value)}}
                variant="outlined"
                required
                fullWidth
                name="password"
                label="Password"
                type="password"
                id="password"
                autoComplete="current-password"
              />
          <FormControlLabel
            control={<Checkbox value="remember" color="primary" />}
            label="Remember me"
          />
         
          <Button
            type="submit"
            fullWidth
            variant="contained"
            color="primary"
            className={classes.submit}
          >
            Sign In
          </Button>
       

          <Grid container justify="center">
            <Grid item>
            <Link style={{color:"black", textDecoration:"none"}} to="/studentR2">
                {"Don't have an account? Sign Up"}
              </Link>
            </Grid>
          </Grid>
        </form>
        <Copyright />
      </div>
    </Container>
         </div>
      </Dialog>
     
    </div>
  );
}