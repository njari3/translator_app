import React, { Component } from "react";
import { getLanguages, GetGroupedWords } from "../services/translatorService";
import DropDown from "./dropDown";
import Input from "./input";
class Translator extends Component {
    state = {
        languages: [],
        languageFrom: " ",
        languageTo: " ",
        input: "",
        result: [],
    };

    async componentDidMount() {
        const { data } = await getLanguages();
        this.setState({ languages: data });
    }
    async TranslateWord(value) {
        if (value.length === 0) return;

        const request = {
            text: value,
            languageFromId: this.state.languageFrom.id,
            languageToId: this.state.languageTo.id,
        };
        const { data } = await GetGroupedWords(request);
        this.setState({ result: data });
    }
    handlelanguageFrom = (department) => {
        this.setState({
            languageFrom: department,
        });
    };
    handlelanguageTo = (department) => {
        this.setState({
            languageTo: department,
        });
    };

    handleChange = ({ currentTarget: input }) => {
        if (this.state.languageFrom === " " || this.state.languageTo === " ")
            return;

        let value = this.state.input;
        if (input.value !== undefined) value = input.value;
        if (
            this.state.languageFrom === undefined ||
            this.state.languageTo === undefined ||
            value === undefined
        ) {
            this.setState({ input: value });
            return;
        }

        this.TranslateWord(value);
        this.setState({ input: value });
        if (value.length === 0) this.setState({ result: [] });
    };
    render() {
        return (
            <div className="container">
                <div className="row align-items-start">
                    <div className="col">
                        <p>Text from:</p>
                        <DropDown
                            items={this.state.languages}
                            selectedItem={this.state.languageFrom}
                            onItemSelect={this.handlelanguageFrom}
                            textProperty={"Language from"}
                        />
                    </div>
                    <div className="col">
                        <p>Translate to:</p>
                        <DropDown
                            items={this.state.languages}
                            selectedItem={this.state.languageTo}
                            onItemSelect={this.handlelanguageTo}
                            textProperty={"Language to"}
                        />
                    </div>
                </div>
                <div className="row align-items-start">
                    <div className="col">
                        <p>Search:</p>
                        <Input
                            name="text"
                            value={this.state.input}
                            onChange={this.handleChange}
                        ></Input>
                    </div>
                    <div className="col">
                        <p>Result:</p>
                        <ul className="list-group list-group-flush">{this.result()}</ul>
                    </div>
                </div>
                <div className="row align-items-start">
                    <div className="col">{this.renderTable()}</div>
                </div>
            </div>
        );
    }
    renderTable() {
        if (this.state.languageFrom === this.state.languageTo) return;
        if (this.state.result.length > 0 && this.CheckIfFoundIt() === "")
            try {
                return this.state.result.map((option) => (
                    <ul
                        key={option.id || ""}
                        className="list-group list-group-horizontal col-sm"
                    >
                        <li key={option.id || ""} className="list-group-item col-sm">
                            {option.originalWord}
                        </li>
                        <li
                            key={option.tranlatedWords[0].id || ""}
                            className="list-group-item col-sm"
                        >
                            {option.tranlatedWords.map((t) => (
                                <em key={t.translatedWordId || ""}>{t.translatedWord}</em>
                            ))}
                        </li>
                    </ul>
                ));
            } catch (error) {
                console.error(error);
            }
        return "";
    }
    CheckIfFoundIt() {
        if (this.state.result.length === 0) return "";
        if (
            this.state.result[0].originalWord.toLowerCase().trim() ===
            this.state.input.toLocaleLowerCase().trim()
        )
            return this.state.result[0].tranlatedWords.map((t) => (
                <div key={t.translatedWordId || ""}>{t.translatedWord}</div>
            ));

        return "";
    }
    result() {
        if (this.state.result.length > 0) {
            const response = this.CheckIfFoundIt();

            if (response !== "")
                return <div className="alert alert-info">{response}</div>;
        }
        if (this.state.input.length === 0 || this.state.result.length > 0)
            return "...";

        return <div className="alert alert-danger">Not found</div>;
    }
}

export default Translator;
