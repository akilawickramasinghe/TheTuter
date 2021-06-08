import React, { useEffect, useState } from "react";
import { makeStyles } from '@material-ui/core/styles';
import Paper from '@material-ui/core/Paper';
import Typography from '@material-ui/core/Typography';
import Grid from '@material-ui/core/Grid';
import Image from '../../images/e.jpg'
import CssBaseline from '@material-ui/core/CssBaseline';
import TextField from '@material-ui/core/TextField';
import Link from '@material-ui/core/Link';
import Button from '@material-ui/core/Button';
import Container from '@material-ui/core/Container';
import Footer from '../Footer/Footer';
import Header from '../Header/Header';
import NavBar from '../NavigationBar/NavBar';
import axios from 'axios';
import  { useHistory , Redirect} from 'react-router-dom'


const useStyles = makeStyles((theme) => ({
  
    mainFeaturedPost: {
      position: 'relative',
      backgroundColor: theme.palette.grey[800],
      color: theme.palette.common.white,
      backgroundImage: `url(${Image})`,
      backgroundSize: 'cover',
      backgroundRepeat: 'no-repeat',
      backgroundPosition: 'center',
      
    },
   
    mainFeaturedPostContent: {
        
      position: 'relative',
      padding: theme.spacing(3),
      [theme.breakpoints.up('xs')]: {
        padding: theme.spacing(10),
        
      },
    },

    paper: {
      marginTop: theme.spacing(4),
      marginBottom: theme.spacing(4),
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
  }));


export default function TeacherR () {

    const classes = useStyles();
    const history = useHistory();

    const [firstName, setFirstName] =  useState("");
    const [lastName, setLastName] =  useState("");
    const [email, setEmail] =  useState("");
    const [phoneNumber, setPhoneNumber] =  useState("");
    const [address, setAddress] =  useState("");
    const [subject, setSubject] =  useState("");
    const [price, setPrice] =  useState("");
    const [password, setPassword] =  useState("");
    const [role, setRole] =  useState("Teacher");
    const [successMessage, setSuccessMessage] =  useState("");
    const [errorMessage, setErrorMessage] =  useState("");

    const onSubmit = (e) => {
      e.preventDefault();
      const postData = {
        firstName,
        lastName,
        email,
        phoneNumber,
        address,
        subject,
        price,
        password,
        role
      };
      axios.post('/api/Accounts/Register', postData)
      .then((res) => {
        if (res.data.length > 0) {
          if (res.data[0].code == "DuplicateUserName") {
            // this.setState({ errorMessage: res.data[0].description });
            setErrorMessage(res.data[0].description);
          }else if(res.data[0].code == "PasswordTooShort")
          {
            setErrorMessage(res.data[0].description);
          }
          debugger
        }else if(res.status == 200){
          debugger
          // this.setState({ successMessage:"Teacher Registered Successfully" });
          history.push("/home");
        }
      }).catch((err) =>{
        // this.setState({ errorMessage: err.message });
        setErrorMessage(err.message);
      });
    }

    return (

      <div className="App">
        <Header />
        <NavBar />
        <div>
            
    <Paper className={classes.mainFeaturedPost}>
      
      <div className={classes.overlay} />
      <Grid container>
        <Grid container justify="center" item xs={12}>
          <div className={classes.mainFeaturedPostContent}>
              
            <Typography component="h1" variant="h3"  gutterBottom>
               TEACHER
            </Typography>
            <Typography variant="h5" color="inherit" paragraph>
             " You can share your knowledge without limit and anyone who is interested in what is being taught can learn from you. At the same time you can earn a good monthly income based on your teaching ability. If you can spend a little extra time on this, you too can go on a successful journey  "
            </Typography>
          </div>
        </Grid>
      </Grid>
    </Paper>
        </div>
        <div >
          
        <Container component="main" maxWidth="xs">
      <CssBaseline />
      <div className={classes.paper}>
        <Typography component="h2" variant="h5" color='primary'>
          Register as a Teacher
        </Typography>
              {successMessage && <span style={{ color: "red", fontSize: "20px" }}>{successMessage}</span>}
              {errorMessage && <span style={{ color: "red", fontSize: "20px" }}>{errorMessage}</span>}
        <form onSubmit={onSubmit} className={classes.form} noValidate>
          <Grid container spacing={2}>
            <Grid item xs={12} sm={6}>
              <TextField
                 onChange={(e) =>{setFirstName(e.target.value)}}
                name="firstName"
                variant="outlined"
                required
                fullWidth
                id="firstName"
                label="First Name"
                autoComplete="first name"
              />
            </Grid>
            <Grid item xs={12} sm={6}>
              <TextField
                onChange={(e) =>{setLastName(e.target.value)}}
                variant="outlined"
                required
                fullWidth
                id="lastName"
                label="Last Name"
                name="lastName"
                autoComplete="last name"
              />
            </Grid>
            <Grid item xs={12}>
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
            </Grid>

            <Grid item xs={12}>
              <TextField
                onChange={(e) =>{setPhoneNumber(e.target.value)}}
                variant="outlined"
                required
                fullWidth
                name="phone_number"
                label="Phone Number"
                id="phone_number"
                autoComplete="phoneNumber"
              />
            </Grid>

            <Grid item xs={12}>
              <TextField
                 onChange={(e) =>{setAddress(e.target.value)}}
                variant="outlined"
                required
                fullWidth
                name="address"
                label="Address"
                id="address"
                autoComplete="address"
              />
            </Grid>
            <Grid item xs={12}>
              <TextField
                 onChange={(e) =>{setSubject(e.target.value)}}
                variant="outlined"
                required
                fullWidth
                name="subject"
                label="subject"
                id="subject"
                autoComplete="subject"
              />
            </Grid>
            <Grid item xs={12}>
              <TextField
                 onChange={(e) =>{setPrice(e.target.value)}}
                variant="outlined"
                required
                fullWidth
                name="price"
                label="price"
                id="price"
                autoComplete="price"
              />
            </Grid>
            
            <Grid item xs={12}>
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
            </Grid>
            <Grid item xs={12}>

            </Grid>
          </Grid>
          <Button
            type="submit"
            fullWidth
            variant="contained"
            color="primary"
            className={classes.submit}
          >
            Sign Up
          </Button>
          <Grid container justify="center">
            <Grid item>
              <Link href="#" variant="body2">
                Already have an account? Sign in
              </Link>
            </Grid>
          </Grid>
        </form>
      </div>
    
    </Container>
        </div>
        <Footer />
      </div> 
    );
  }