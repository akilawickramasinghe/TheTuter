import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Paper from '@material-ui/core/Paper';
import Grid from '@material-ui/core/Grid';
import Header from '../Header/Header'
import NavBar from '../NavigationBar/NavBar'
import Footer from '../Footer/Footer';
import Image1 from '../../images/c1.png'
import Image2 from '../../images/c2.png'
import Image3 from '../../images/c3.png'
import Image4 from '../../images/c4.png'
import Image5 from '../../images/c5.png'
import Image6 from '../../images/c6.png'
import Image7 from '../../images/q.jpg'

const useStyles = makeStyles((theme) => ({
  root: {
    flexGrow: 1,
  },

  
  paper: {
    padding: theme.spacing(5),
    textAlign: 'center',
    color: theme.palette.text.secondary,
  },

  background5: {
    position: 'relative',
    backgroundImage: `url(${Image7})`,
    backgroundSize: 'cover',
    backgroundRepeat: 'no-repeat',
    backgroundPosition: 'center',
    
  },
}));

export default function Institute() {
  const classes = useStyles();

  return (
    <div className={classes.root}>
        <Header />
        <NavBar />
        <div className={classes.background5}>
      <Grid container spacing={3} className={classes.paper}>
        <Grid container alignItems="center" justify="center" item xs>
          <Paper className={classes.paper}><img src={Image1} width ='200'  alt="c1" ></img></Paper>
        </Grid>
        <Grid container alignItems="center" justify="center" item xs>
          <Paper className={classes.paper}><img src={Image2} width ='200'  alt="c2" ></img></Paper>
        </Grid>
        <Grid container alignItems="center" justify="center" item xs>
          <Paper className={classes.paper}><img src={Image3} width ='200'  alt="c3" ></img></Paper>
        </Grid>
      </Grid>
      <Grid container spacing={3} className={classes.paper} >
        <Grid container alignItems="center" justify="center" item xs>
          <Paper className={classes.paper}><img src={Image4} width ='200'  alt="c4" ></img></Paper>
        </Grid>
        <Grid container alignItems="center" justify="center" item xs>
          <Paper className={classes.paper}><img src={Image5} width ='200'  alt="c5" ></img></Paper>
        </Grid>
        <Grid container alignItems="center" justify="center" item xs>
          <Paper className={classes.paper}><img src={Image6} width ='200'  alt="c6" ></img></Paper>
        </Grid>
      </Grid>
      </div>
      <Footer />
    </div>
  );
}