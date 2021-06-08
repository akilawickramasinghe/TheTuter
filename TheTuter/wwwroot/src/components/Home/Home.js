import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Paper from '@material-ui/core/Paper';
import Typography from '@material-ui/core/Typography';
import Grid from '@material-ui/core/Grid';
import Image from '../../images/a.jpg'
import Image1 from '../../images/j.jpg'
import SearchIcon from '@material-ui/icons/Search';
import InputBase from '@material-ui/core/InputBase';
import { fade } from '@material-ui/core/styles';
import Footer from '../Footer/Footer';
import Header from '../Header/Header'
import NavBar from '../NavigationBar/NavBar'

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
  overlay: {
    position: 'absolute',
    top: 0,
    bottom: 0,
    right: 0,
    left: 0,
    backgroundColor: 'rgba(0,0,0,.3)',
  },
  mainFeaturedPostContent: {
      
    
    position: 'relative',
    padding: theme.spacing(3),
    [theme.breakpoints.up('xs')]: {
      padding: theme.spacing(10),
      
    },
  },

  search: {
    position: 'relative',
    borderRadius: theme.shape.borderRadius,
    backgroundColor: fade(theme.palette.common.white, 0.35),
    '&:hover': {
      backgroundColor: fade(theme.palette.common.white, 0.55),
    },
    marginRight: theme.spacing(25),
    marginLeft: 0,
    width: '100%',
    [theme.breakpoints.up('sm')]: {
      marginLeft: theme.spacing(20),
      width: 'auto',
    },
  },
  searchIcon: {
    padding: theme.spacing(0, 2),
    height: '100%',
    position: 'absolute',
    pointerEvents: 'none',
    display: 'flex',
    alignItems: 'center',
    justifyContent: 'center',
  },

  
  
  inputInput: {
    padding: theme.spacing(1, 1, 1, 0),
    // vertical padding + font size from searchIcon
    paddingLeft: `calc(1em + ${theme.spacing(4)}px)`,
    transition: theme.transitions.create('width'),
    width: '100%',
    [theme.breakpoints.up('md')]: {
      width: '30ch',
    },
  },
  
}));

export default function Home() {
  const classes = useStyles();
  
  return (
    <div>
      <Header />
        <NavBar />
      
    <Paper className={classes.mainFeaturedPost}>
      
      <div className={classes.overlay} />
      <Grid container >
        <Grid container justify="center" item xs={12}>
          <div className={classes.mainFeaturedPostContent}>
              
            <Typography component="h1" variant="h3"  gutterBottom>
                E - Learning
            </Typography>
            <Typography variant="h5" color="inherit" paragraph>
             " Online learning is rapidly becoming one of the most cost-effective ways to educate the world’s rapidly expanding workforce "
            </Typography>
            <div className={classes.search}>
            <div className={classes.searchIcon}>
              <SearchIcon />
            </div>
            <InputBase
              placeholder="Search courses & subjects"
              classes={{
                root: classes.inputRoot,
                input: classes.inputInput,
              }}
            />
           
          </div>
          
          </div>
         
        </Grid>
      </Grid>
    </Paper>
    <div>
           <img src={Image1} width ='100%' height='auto' alt="logo" ></img>
           </div>
    <Footer />
    </div>
  );
}

