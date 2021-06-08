import PropTypes from 'prop-types';
import { makeStyles } from '@material-ui/core/styles';
import Paper from '@material-ui/core/Paper';
import Grid from '@material-ui/core/Grid';
import '../Contact/Contact.css';
import Header from '../Header/Header'
import NavBar from '../NavigationBar/NavBar'
import Footer from '../Footer/Footer';
import Image from '../../images/w.jpg';
import axios from 'axios';
import React, { useState } from "react";
import TextField from '@material-ui/core/TextField';

const useStyles = makeStyles((theme) => ({
  
  Contact: {
    position: 'relative',
    backgroundImage: `url(${Image})`,
    backgroundSize: 'cover',
    backgroundRepeat: 'no-repeat',
    backgroundPosition: 'center',
    
  },
 
  aboutPostContent: {
      
    position: 'relative',
    padding: theme.spacing(3),
    [theme.breakpoints.up('xs')]: {
      padding: theme.spacing(6),
      paddingRight: 0,
    },
  },

}));

export default function Contact() {
  const classes = useStyles();
  const [fullName, setFullName] =  useState("");
  const [email, setEmail] =  useState("");
  const [phone, setPhone] =  useState("");
  const [message, setMessage] =  useState("");
  const [errorMessage, setErrorMessage] =  useState("");
  const [successMessage, setSuccessMessage] =  useState("");

  const onSubmit = (async(e) => {
    e.preventDefault();
    const postData = {
      fullName,
      email,
      phone,
      message,
    };
      await axios.post('/api/Accounts/ContactUs', postData)
    .then((res) => {
      debugger
      if(res.data == "EmailSuccessfully"){
        setSuccessMessage("Email has been sent!");
      }else if(res.data == "EmailNotSuccessfully"){
        setSuccessMessage("Email not sent!");
      }
    }).catch((err) =>{
      setErrorMessage(err.message);
    });
  });
  
  return (
    <div>
         <Header />
        <NavBar />
    <Paper className={classes.Contact}>
      <Grid container >
          <div className="container contact-form">
            <div className="contact-image">
              <img src="https://image.ibb.co/kUagtU/rocket_contact.png" alt="rocket_contact" />
            </div>
            <form onSubmit={onSubmit}>
              <h3>Drop Us a Message</h3>
              {successMessage && <span style={{ color: "red", fontSize: "20px", marginTop:"5px" }}>{successMessage}</span>}
              {errorMessage && <span style={{ color: "red", fontSize: "20px", marginTop:"5px"}}>{errorMessage}</span>}
              <div className="row">
                <div className="col-md-6">
                  <div className="form-group mb-3">
                    <TextField
                      onChange={(e) => { setFullName(e.target.value) }}
                      name="fullName"
                      variant="outlined"
                      required
                      fullWidth
                      id="fullName"
                      label="Full Name"
                      autoComplete="Full Name"
                    />
                    {/* <input onChange={(e) =>{setFullName(e.target.value)}} type="text" name="fullName" className="form-control" placeholder="Your Name *" value="" /> */}
                  </div>
                  <div className="form-group mb-3">
                  <TextField
                      onChange={(e) => { setEmail(e.target.value) }}
                      name="email"
                      variant="outlined"
                      type="email"
                      required
                      fullWidth
                      id="email"
                      label="Email"
                      autoComplete="Email"
                    />
                  </div>
                  <div className="form-group mb-3">
                  <TextField
                      onChange={(e) => { setPhone(e.target.value) }}
                      name="phone"
                      variant="outlined"
                      type="phone"
                      required
                      fullWidth
                      id="phone"
                      label="Phone"
                      autoComplete="Phone"
                    />
                  </div>
                  <div className="form-group mb-3">
                    <input type="submit" name="btnSubmit" className="btnContact" value="Send Message" />
                  </div>
                </div>
                <div className="col-md-6">
                  <div className="form-group mb-3">
                    <textarea onChange={(e) =>{setMessage(e.target.value)}} name="message" className="form-control" placeholder="Your Message *" style={{ width: '100%', height: '200px' }}></textarea>
                  </div>
                </div>
              </div>
            </form>
          </div>
      </Grid>
    </Paper>
    <Footer />
    </div>
  );
}