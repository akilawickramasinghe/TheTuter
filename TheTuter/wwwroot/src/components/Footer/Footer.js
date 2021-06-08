import React from 'react';
import PropTypes from 'prop-types';
import { makeStyles } from '@material-ui/core/styles';
import Container from '@material-ui/core/Container';
import Typography from '@material-ui/core/Typography';
import { Link } from 'react-router-dom';
import {grey} from '@material-ui/core/colors';
import { createMuiTheme} from '@material-ui/core'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faCoffee } from '@fortawesome/free-solid-svg-icons'
import logo from '../../images/logo.png'
import '../Footer/Footer.css'

const theme =createMuiTheme({
    palette:{
      primary:{
        main:grey[900]
      },
    }
  })
  

const useStyles = makeStyles((theme) => ({
  // footer: {
  //   backgroundColor:grey[700],
  //   marginTop: theme.spacing(8),
  //   padding: theme.spacing(6, 0),
  // },
}));

export default function Footer() {
  const classes = useStyles();

  return (
  
    <footer className="footer-bg text-white text-center text-lg-start">
  <div className="container p-4">
    <div className="row pt-5">
      <div className="col-lg-3 col-md-12 mb-4 mb-md-0">
      <h4 className="text-uppercase mb-3 ">ONLINE EDUCATION</h4>
      <img src={logo} width ='75' alt="logo" ></img>
      
        <p >
        A/L Classes<br />
        O/L Classes<br />
        Social Development courses<br />  
        Professinal Courses<br />  
        </p>
        <ul id="menu">
          <li><i class="fab fa-facebook-f"></i></li>
          <li><i class="fab fa-instagram"></i></li>
          <li><i class="fab fa-linkedin-in"></i></li>
          <li><i class="fab fa-youtube"></i></li>
          <li><i class="fab fa-google-plus"></i></li>
        </ul> 
      </div>
      <div className="col-lg-3 col-md-6 mb-4 mb-md-0">
        <h4 className="text-uppercase mb-4">Useful Links</h4>
        <hr className="text-white col-10 bolder" />

        <ul className="list-unstyled mb-0">
          <li className="mb-3">
           
            <Link style={{color:"white", textDecoration:"none"}} to="/about">ABOUT </Link>
          </li>
          <li className="mb-3">
          <Link style={{color:"white", textDecoration:"none"}} to="/contact">CONTACT US </Link>
          </li>
          <li className="mb-3">
          <Link style={{color:"white", textDecoration:"none"}} to="/about">INSTITUTES </Link>
          </li>
        </ul>
      </div>
      <div className="col-lg-3 col-md-6 mb-4 mb-md-0">
        <h4 className="text-uppercase mb-4"> We offer</h4>
        <hr className="text-white col-10 bolder" />
        <ul className="list-unstyled mb-0">
          <li className="mb-3">
            <a href="#!" className="text-decoration-none text-white"><i class="fas fa-angle-right"></i> A/L Classes</a>
          </li>
          <li className="mb-3">
            <a href="#!" className="text-decoration-none text-white"><i class="fas fa-angle-right"></i> O/L Classes</a>
          </li>
          <li className="mb-3">
            <a href="#!" className="text-decoration-none text-white"><i class="fas fa-angle-right"></i> Social Development courses</a>
          </li>
          <li className="mb-3">
            <a href="#!" className="text-decoration-none text-white"><i class="fas fa-angle-right"></i> Professinal Courses</a>
          </li>
        </ul>
      </div>

      <div className="col-lg-3 col-md-6 mb-4 mb-md-0 ">
        
        <h4 className="text-uppercase mb-4">Contact Us</h4>
        <hr className="text-white col-10 bolder" />
        <h6 className="mt-3" ><i class="fas fa-map-marker-alt"></i> Address</h6>
        <p >
        ONLINE EDUCATION <br />
        University of Ruhuna<br />
        Faculty of Engineering<br />
        </p>
        <h6 ><i class="fas fa-phone"></i> Phone</h6>
        <p >
        0710888777<br />
        </p>
      </div>



    </div>
  </div>
  <div className="text-center p-5 bg-dark"  >
  
    © 2021 Copyright at
    <a className="text-decoration-none text-white" href="#"> OnlineEducation.com</a>
  </div>
</footer>

    

  );
}