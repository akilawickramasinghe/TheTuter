import React from 'react';
import PropTypes from 'prop-types';
import { makeStyles } from '@material-ui/core/styles';
import Paper from '@material-ui/core/Paper';
import Grid from '@material-ui/core/Grid';
import std1 from '../../images/zz.jpg'
import std2 from '../../images/student02.jpg'
import Header from '../Header/Header'
import NavBar from '../NavigationBar/NavBar'
import Footer from '../Footer/Footer';
import '../About/About.css'

const useStyles = makeStyles((theme) => ({
  
  About: {
    position: 'relative',
    marginBottom: theme.spacing(0),
    backgroundSize: 'cover',
    backgroundRepeat: 'no-repeat',
    backgroundPosition: 'center',
    
  },
 
  aboutPostContent: {
      
    position: 'relative',
    padding: theme.spacing(3),
    [theme.breakpoints.up('xs')]: {
      padding: theme.spacing(10),
      paddingRight: 10,
    },
  },

}));

export default function About() {
  const classes = useStyles();
  
  return (
      <div>
        <Header />
        <NavBar />
    <Paper className={classes.About}>
      
      <div className={classes.overlay} />
      <Grid container >
        <div className="background2" >
          <div className={classes.aboutPostContent}>
            <div className="col-lg-12">
            <h1 className="col-12  text-center mb-5">
              ABOUT US
            </h1>
            <div className="col-lg-12">
            
            <div className="col-lg-12 col-sm-12 float-left pt-2 justify-content-center">
            <h5 className=" mb-4">
            TODAY’S KNOWLEDGE, TOMORROW’S SUCCESS THROUGH ONLINE LEARNING
            </h5>
            <p class="text-justify">
            onlinetuition.lk is a one-on-one online educational platform that connects Sri Lankan students with tutors. The students are able to accrete knowledge of academic disciplines through one-on-one tuition classes held by professionals and scholars who are specialized in specific subject areas. The tutors enrolled with onlinetuition.lk are high achievers with exceptional track records in their academic career. Most of the tutors are graduates and undergraduates from leading engineering, management and medical universities in Sri Lanka. This diverse tutor panel consists of academic researchers in their specialized fields and integrates new teaching techniques when conducting online classes.
              </p>
            
            
            </div>
            <div className="col-lg-12 col-sm-12 mt-4 pb-1 float-left pt-3 d-flex justify-content-center">
            <img src={std1} width ='500' height ='350' alt="logo" ></img>
            </div>
            </div>

            <div className="justify-content-between mt-5 pt-2 d-flex pr-5">
            
            <div className="col-lg-12 float-right pt-2 justify-content-center">
            
            <u><h6 className=" mt-1 mb-4">
            TEACHING TECHNIQUES
            </h6></u>
            <p>The teacher panel mainly follows and implements 5 strategies to improve your online e-learning course a student friendly experience. They are as follows,</p>

            <ol>
              <li className="mb-4">
                Create a supportive learning environment
              </li>
              <li className="mb-4">
                Collaborate audio and visual tools - This gives the sense of working with a mix of activities which increase student engagement with tutor and other learners.
              </li>
              <li className="mb-4">
                Provide ongoing feedback - The tutor will provide the feedback in order to promote and motivate the students to dive deep to acquire subject knowledge.
              </li>
              <li className="mb-4">
                Student centered education
              </li>
            </ol>
           
            <p className="text-justify" >
            The student can decide on the pace of the lessons and key subject areas to be addressed. The teachers will encourage the students to actively engage when teaching. The students will be encouraged to develop their problem-solving skills and critical thinking.onlinetuition.lk paves the way to create a positive and collaborative learning environment for students by allowing them to curate their own tutoring style. This is to facilitate quality online tuition experience in order to gain knowledge in a timely way, going beyond the traditional educational experience.
            </p>
           
            </div>
            </div>
            </div>
          </div>
          </div>
      </Grid>
    </Paper>
    <Footer />
    </div>
  );
}