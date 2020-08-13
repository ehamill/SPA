import React, { Component } from 'react';
import authService from './api-authorization/AuthorizeService'

export class CityView extends Component {
  //static displayName = FetchData.name;

  constructor(props) {
    super(props);
      this.state = {city: {}, loading: true };
  }

  componentDidMount() {
    this.getCityData();
  }

    static renderCity(city) {
      return (
          <div>Getting City data, cityName {city.cityName} {city.cityId}
              server {city.serverId} 
              <h1>cityName {city.cityName} {city.cityId}
                  server {city.serverId}
              </h1>
          </div>
          
   );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : CityView.renderCity(this.state.city);

      return (
          <div>
       <h1 id="cityView" >City</h1>
        <p>Getting city from server.</p>
              {contents}
      </div>
    );
  }

  async getCityData() {
    const token = await authService.getAccessToken();
    const response = await fetch('City', {
      headers: !token ? {} : { 'Authorization': `Bearer ${token}` }
    });
    const data = await response.json();
      
    //console.log('data: ' + JSON.stringify(data) + data.city.cityName);
    this.setState({ city: data.city, loading: false });
  }
}
