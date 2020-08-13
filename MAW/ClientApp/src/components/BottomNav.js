import React, { Component } from 'react';
import authService from './api-authorization/AuthorizeService';

export class BottomNav extends Component {
  //static displayName = NavMenu.name;


    constructor(props) {
        super(props);

        this.state = {
            isAuthenticated: false,
            userName: null
        };
    }

    componentDidMount() {
        this._subscription = authService.subscribe(() => this.populateState());
        this.populateState();
    }

    componentWillUnmount() {
        authService.unsubscribe(this._subscription);
    }

    async populateState() {
        const [isAuthenticated, user] = await Promise.all([authService.isAuthenticated(), authService.getUser()])
        this.setState({
            isAuthenticated,
            userName: user && user.name
        });
    }


  render () {
      const { isAuthenticated, userName } = this.state;
      if (!isAuthenticated) {
          return (
              <nav className="navbar fixed-bottom navbar-light bg-light">
                  <a className="navbar-brand" href="#jlj">Not logged in Bottom Nav</a>
              </nav>
          );
      } else {
          return (
              <nav className="navbar fixed-bottom navbar-light bg-light" >
                  <a className="navbar-brand" href="#hkjh">Logged in Bottom Nav {userName}</a>
              </nav>
          );
      }

  }
}
